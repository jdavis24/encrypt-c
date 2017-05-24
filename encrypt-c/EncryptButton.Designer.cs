namespace encrypt_c
{
    partial class EncryptButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EncryptButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.EncryptEmail = this.Factory.CreateRibbonGroup();
            this.EncryptBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.EncryptEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.EncryptEmail);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // EncryptEmail
            // 
            this.EncryptEmail.Items.Add(this.EncryptBtn);
            this.EncryptEmail.Label = "Encrypt Email";
            this.EncryptEmail.Name = "EncryptEmail";
            this.EncryptEmail.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupMailNew");
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.EncryptBtn.Image = global::encrypt_c.Properties.Resources._lock;
            this.EncryptBtn.Label = "New Encrypted Email";
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Position = this.Factory.RibbonPosition.BeforeOfficeId("MailNewItemMenu");
            this.EncryptBtn.ScreenTip = "Create New Encrypted Email";
            this.EncryptBtn.ShowImage = true;
            this.EncryptBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EncryptBtn_Click);
            // 
            // EncryptButton
            // 
            this.Name = "EncryptButton";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EncryptButton_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.EncryptEmail.ResumeLayout(false);
            this.EncryptEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EncryptEmail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EncryptBtn;
    }

    partial class ThisRibbonCollection
    {
        internal EncryptButton EncryptButton
        {
            get { return this.GetRibbon<EncryptButton>(); }
        }
    }
}
