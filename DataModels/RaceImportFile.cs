namespace BirdRacing.DataModels
{
    public class RaceImportFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string ImportDate { get; set; }
        public string ImportStatus { get; set; }
        public string ErrorMessage { get; set; }
        public RaceData Data { get; set; }

        public RaceImportFile()
        {
            FileName = string.Empty;
            FilePath = string.Empty;
            ImportDate = string.Empty;
            ImportStatus = "Pending";
            ErrorMessage = string.Empty;
            Data = new RaceData();
        }

        public RaceImportFile(string fileName, string filePath, string importDate, string importStatus, string errorMessage, RaceData data)
        {
            FileName = fileName;
            FilePath = filePath;
            ImportDate = importDate;
            ImportStatus = importStatus;
            ErrorMessage = errorMessage;
            Data = data;
        }
    }
}