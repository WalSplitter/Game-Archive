using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string applicationLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            applicationLocation = applicationLocation.Substring(0, applicationLocation.LastIndexOf('\\'));

            GameArchiveDataSetTableAdapters.DirectoryTableAdapter directoryAdapter = new GameArchiveDataSetTableAdapters.DirectoryTableAdapter();
            GameArchiveDataSet.DirectoryDataTable allData = directoryAdapter.GetData();

            for (int i = 0; i < allData.Count; i++)
            {
                if (allData[i]["Description"] is System.DBNull)
                {
                    lb_foundPath.Items.Add(allData[i].Path);
                }
                else
                {
                    lb_foundPath.Items.Add(allData[i].Description + ": " + allData[i].Path);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_save.Checked)
                {
                    //save current directory
                    //string applicationLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
                    //applicationLocation = applicationLocation.Substring(0, applicationLocation.LastIndexOf('\\'));

                    GameArchiveDataSetTableAdapters.DirectoryTableAdapter directoryAdapter = new GameArchiveDataSetTableAdapters.DirectoryTableAdapter();

                    GameArchiveDataSet.DirectoryDataTable allData = directoryAdapter.GetData();
                    bool foundEntry = false;
                    var foundEntryId = Guid.NewGuid();

                    for (int i = 0; i < allData.Count; i++)
                    {
                        if (allData[i].Path == txt_directory.Text)
                        {
                            foundEntry = true;
                            foundEntryId = allData[i].ID;
                            break;
                        }
                    }

                    if (foundEntry)
                    {
                        //not needed
                        //directoryAdapter.UpdateQuery(applicationLocation, null, foundEntryId);
                    }
                    else
                    {
                        directoryAdapter.InsertQuery(Guid.NewGuid(), txt_directory.Text, null);
                    }
                }

                if (txt_directory.Text == String.Empty)
                {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        txt_directory.Text = folderBrowserDialog.SelectedPath;
                        string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                        ImageList imageListSmall = new ImageList();
                        ImageList imageListLarge = new ImageList();
                        for (int i = 0; i < files.Length; i++)
                        {
                            ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(files[i]), i);
                            item.SubItems.Add(files[i]);

                            imageListSmall.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                            imageListLarge.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                            lv_gameArchive.Items.Add(item);
                        }

                        lv_gameArchive.SmallImageList = imageListSmall;
                        lv_gameArchive.LargeImageList = imageListLarge;
                    }
                }
                else
                {
                    string[] files = Directory.GetFiles(txt_directory.Text);
                    ImageList imageListSmall = new ImageList();
                    ImageList imageListLarge = new ImageList();
                    for (int i = 0; i < files.Length; i++)
                    {
                        ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(files[i]), i);
                        item.SubItems.Add(files[i]);

                        imageListSmall.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                        imageListLarge.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                        lv_gameArchive.Items.Add(item);
                    }

                    lv_gameArchive.SmallImageList = imageListSmall;
                    lv_gameArchive.LargeImageList = imageListLarge;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cb_save_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_save.Checked && txt_directory.Text != String.Empty)
            {
                //save current directory
                GameArchiveDataSetTableAdapters.DirectoryTableAdapter directoryAdapter = new GameArchiveDataSetTableAdapters.DirectoryTableAdapter();

                GameArchiveDataSet.DirectoryDataTable allData = directoryAdapter.GetData();
                bool foundEntry = false;
                var foundEntryId = Guid.NewGuid();

                for (int i = 0; i < allData.Count; i++)
                {
                    if (allData[i].Path == txt_directory.Text)
                    {
                        foundEntry = true;
                        foundEntryId = allData[i].ID;
                        break;
                    }
                }

                if (foundEntry)
                {
                    //not needed
                    //directoryAdapter.UpdateQuery(applicationLocation, null, foundEntryId);
                }
                else
                {
                    directoryAdapter.InsertQuery(foundEntryId, txt_directory.Text, null);
                }
            }
        }

        private void lb_foundPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_directory.Text = lb_foundPath.SelectedItem.ToString();
        }

        private void lv_gameArchive_DoubleClick(object sender, EventArgs e)
        {
            string path = lv_gameArchive.SelectedItems[0].SubItems[1].Text;
            System.Diagnostics.Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_directory.Text = String.Empty;
        }
    }
}