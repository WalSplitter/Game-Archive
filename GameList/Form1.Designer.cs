namespace GameList
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_save = new System.Windows.Forms.CheckBox();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.lv_gameArchive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameArchiveDataSet = new GameList.GameArchiveDataSet();
            this.lb_foundPath = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArchiveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(473, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(62, 47);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.BackColor = System.Drawing.Color.Transparent;
            this.cb_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_save.Location = new System.Drawing.Point(473, 62);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(97, 17);
            this.cb_save.TabIndex = 2;
            this.cb_save.Text = "Pfad speichern";
            this.cb_save.UseVisualStyleBackColor = false;
            this.cb_save.CheckedChanged += new System.EventHandler(this.cb_save_CheckedChanged);
            // 
            // txt_directory
            // 
            this.txt_directory.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_directory.Location = new System.Drawing.Point(31, 12);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.Size = new System.Drawing.Size(436, 20);
            this.txt_directory.TabIndex = 3;
            // 
            // lv_gameArchive
            // 
            this.lv_gameArchive.BackColor = System.Drawing.SystemColors.Menu;
            this.lv_gameArchive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_gameArchive.Location = new System.Drawing.Point(31, 166);
            this.lv_gameArchive.Name = "lv_gameArchive";
            this.lv_gameArchive.ShowItemToolTips = true;
            this.lv_gameArchive.Size = new System.Drawing.Size(555, 343);
            this.lv_gameArchive.TabIndex = 5;
            this.lv_gameArchive.UseCompatibleStateImageBehavior = false;
            this.lv_gameArchive.View = System.Windows.Forms.View.Tile;
            this.lv_gameArchive.DoubleClick += new System.EventHandler(this.lv_gameArchive_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datei Namen";
            this.columnHeader1.Width = 662;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.gameArchiveDataSet;
            this.bindingSource1.Position = 0;
            // 
            // gameArchiveDataSet
            // 
            this.gameArchiveDataSet.DataSetName = "GameArchiveDataSet";
            this.gameArchiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_foundPath
            // 
            this.lb_foundPath.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_foundPath.FormattingEnabled = true;
            this.lb_foundPath.Location = new System.Drawing.Point(31, 62);
            this.lb_foundPath.Name = "lb_foundPath";
            this.lb_foundPath.Size = new System.Drawing.Size(436, 69);
            this.lb_foundPath.TabIndex = 6;
            this.lb_foundPath.SelectedIndexChanged += new System.EventHandler(this.lb_foundPath_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gespeicherte Pfade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gefundene Dateien:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pfad leeren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_foundPath);
            this.Controls.Add(this.lv_gameArchive);
            this.Controls.Add(this.txt_directory);
            this.Controls.Add(this.cb_save);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Archive";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArchiveDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.CheckBox cb_save;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListView lv_gameArchive;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GameArchiveDataSet gameArchiveDataSet;
        private System.Windows.Forms.ListBox lb_foundPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

