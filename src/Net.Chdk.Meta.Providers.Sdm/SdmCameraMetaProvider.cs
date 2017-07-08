using System.IO;

namespace Net.Chdk.Meta.Providers.Sdm
{
    sealed class SdmCameraMetaProvider : ICameraMetaProvider
    {
        public CameraInfo GetCamera(string name)
        {
            var split = Path.GetFileNameWithoutExtension(name).Split('-');
            return new CameraInfo
            {
                Platform = split[2],
                Revision = split[3]
            };
        }
    }
}
