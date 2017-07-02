using Net.Chdk.Model.Software;
using System.IO;

namespace Net.Chdk.Meta.Providers.Sdm
{
    sealed class SdmCameraMetaProvider : ICameraMetaProvider
    {
        public SoftwareCameraInfo GetCamera(string name)
        {
            var split = Path.GetFileNameWithoutExtension(name).Split('-');
            return new SoftwareCameraInfo
            {
                Platform = split[2],
                Revision = split[3]
            };
        }
    }
}
