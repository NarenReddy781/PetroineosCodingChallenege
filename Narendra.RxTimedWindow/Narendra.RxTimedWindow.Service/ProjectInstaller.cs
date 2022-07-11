using System.ComponentModel;
using System.Configuration.Install;

namespace Narendra.RXTimedWindow.Service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}