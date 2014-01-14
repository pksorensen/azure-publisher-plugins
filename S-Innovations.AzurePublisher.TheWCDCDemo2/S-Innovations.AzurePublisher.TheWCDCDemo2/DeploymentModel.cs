using SInnovations.WindowsAzure.Publisher.Plugins;
using SInnovations.WindowsAzure.Publisher.Plugins.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInnovations.AzurePublisher.TheWCDCDemo2
{
    public class DeploymentModel : ICloudServiceDeploymentModel
    {

        [DeploymentSetting(SettingName = "Composite.WindowsAzure.WebRole.DeploymentName", Writable = true)]
        [Display(Name = "Deployment Name", Order = 1)]
        [Required]
        public string DeploymentName { get; set; }


        public void ManipulateConfiguration(System.Xml.Linq.XDocument configuration)
        {
            throw new NotImplementedException();
        }

        public Task<Uri> GetPackageUriAsync(System.Xml.Linq.XDocument configuration, string size = "ExtraSmall")
        {
            throw new NotImplementedException();
        }
    }
}
