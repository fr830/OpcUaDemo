using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;

namespace TongFang.OpcUa.Client
{
    public partial class SelectLocaleDlg : Form
    {
        #region Constructors
        /// <summary>
        /// Creates an empty form.
        /// </summary>
        public SelectLocaleDlg()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private Session m_session;
        #endregion

        #region Public Interface
        /// <summary>
        /// Displays the available areas in a tree view.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <returns></returns>
        public string ShowDialog(Session session)
        {
            m_session = session;

            LocaleCB.Items.Clear();

            // get the locales from the server.
            DataValue value = m_session.ReadValue(VariableIds.Server_ServerCapabilities_LocaleIdArray);

            if (value != null)
            {
                string[] availableLocales = value.GetValue<string[]>(null);

                if (availableLocales != null)
                {
                    for (int ii = 0; ii < availableLocales.Length; ii++)
                    {
                        LocaleCB.Items.Add(availableLocales[ii]);
                    }
                }
            }

            // select the current locale.
            if (LocaleCB.Items.Count > 0)
            {
                LocaleCB.SelectedIndex = 0;
            }

            // display the dialog.
            if (ShowDialog() != DialogResult.OK)
            {
                return null;
            }

            return LocaleCB.SelectedItem as string;
        }
        #endregion

        #region Private Methods
        #endregion

        #region Event Handlers
        #endregion
    }
}
