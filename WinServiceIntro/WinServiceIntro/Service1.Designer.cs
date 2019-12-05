namespace WinServiceIntro
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spGetBirthdayTableAdapter1 = new WinServiceIntro.DataSetBirthdayTableAdapters.spGetBirthdayTableAdapter();
            this.dataSetBirthday1 = new WinServiceIntro.DataSetBirthday();
            this.commonTableAdapter1 = new WinServiceIntro.DataSetBirthdayTableAdapters.CommonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBirthday1)).BeginInit();
            // 
            // spGetBirthdayTableAdapter1
            // 
            this.spGetBirthdayTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetBirthday1
            // 
            this.dataSetBirthday1.DataSetName = "DataSetBirthday";
            this.dataSetBirthday1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBirthday1)).EndInit();

        }

        #endregion

        private DataSetBirthdayTableAdapters.spGetBirthdayTableAdapter spGetBirthdayTableAdapter1;
        private DataSetBirthday dataSetBirthday1;
        private DataSetBirthdayTableAdapters.CommonTableAdapter commonTableAdapter1;
    }
}
