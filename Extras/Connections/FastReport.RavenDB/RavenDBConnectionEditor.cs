﻿using FastReport.Utils;
using FastReport.Data.ConnectionEditors;

namespace FastReport.Data
{
    /// <summary>
    /// Represents a RavenDB connection editor.
    /// </summary>
    public partial class RavenDBConnectionEditor : ConnectionEditorBase
    {
        #region Fields

        private string FConnectionString;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RavenDBConnectionEditor"/> class. 
        /// </summary>
        public RavenDBConnectionEditor()
        {
            InitializeComponent();
            Localize();
        }

        #endregion Constructors

        #region Private Methods

        private void Localize()
        {
            MyRes res = new MyRes("ConnectionEditors,Common");
            gbServer.Text = res.Get("ServerLogon");
            lblUserName.Text = res.Get("UserName");
            lblPassword.Text = res.Get("Password");
            gbDatabase.Text = res.Get("Database");
            lblDatabase.Text = res.Get("DatabaseName");

            res = new MyRes("Export,Email");
        }

        #endregion Private Methods

        #region Protected Methods

        /// <inheritdoc/>
        protected override string GetConnectionString()
        {
            RavenDBConnectionStringBuilder builder = new RavenDBConnectionStringBuilder();
            builder.DatabaseName = tbDatabase.Text;
            builder.Host = tbHost.Text;
            builder.Username = tbUserName.Text;
            builder.Password = tbPassword.Text;
            return builder.ToString();
        }

        /// <inheritdoc/>
        protected override void SetConnectionString(string value)
        {
            FConnectionString = value;
            RavenDBConnectionStringBuilder builder = new RavenDBConnectionStringBuilder(value);
            tbDatabase.Text = builder.DatabaseName;
            tbHost.Text = builder.Host;
            tbUserName.Text = builder.Username;
            tbPassword.Text = builder.Password;
        }

        #endregion Protected Methods
    }
}
