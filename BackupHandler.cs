using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace TechArmy
{
    class BackupHandler
    {
        private const string PathToServiceAccountKeyFile = "Credentials.json";
        private const string UploadFileName = "backup.txt";
        private readonly string timeStamp;


        static string[] Scopes = { DriveService.ScopeConstants.Drive };

        public BackupHandler(DateTime time)
        {
            //This constructor takes the timestamp and transforms it into a properly formatted timestamp
            //to label the backup files with
            timeStamp = time.ToString("dddd, dd MMMM yyyy HH:mm:ss");

        }

        public async Task FileUploadAsync()
        {
            // credentials variable
            UserCredential credential = null;

            using (var stream = new FileStream(PathToServiceAccountKeyFile, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            //service variable
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            //This is an abstract method for file metadata
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = timeStamp + ".txt"

                // Uncomment this code if you want to put the file into a folder and specify the folder ID
                // You will have to create the folder before-hand on Drive and take its ID key for it to work
                //Parents = new List<string>() { FolderID }
            };

            string uploadedFileId;
            // Create a new file on Google Drive
            using (var fsSource = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
            {
                // Create a new file, with metadata and stream.
                var request = service.Files.Create(fileMetadata, fsSource, "text/plain");
                request.Fields = "*";
                var results = await request.UploadAsync(CancellationToken.None);

                if (results.Status == UploadStatus.Failed)
                {
                    Console.WriteLine($"Error uploading file: {results.Exception.Message}");
                }

                // the file id of the new file we created
                uploadedFileId = request.ResponseBody?.Id;

            }
        }
    }
}
