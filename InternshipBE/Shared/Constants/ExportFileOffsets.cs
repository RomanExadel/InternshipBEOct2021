namespace Shared.Constants
{
    public static class ExportFileOffsets
    {
        public const string INTERNSHIP_VALUE_OFFSET = "B1";
        public const string CANDIDATE_COUNT_VALUE_OFFSET = "B2";
        public const string CANDIDATE_COUNT_NAME_OFFSET = "A2";
        public const string STYLE_RANGE_OFFSET = "A1:A2";
        public const string STYLE_RANGE_ARRAY_NAME_OFFSET = "A4:C4";
        public const int INTERNSHIP_NAME_COLUMN_OFFSET = 1;
        public const int INTERNSHIP_NAME_ROW_OFFSET = 1;
    }

    public static class ExportFileColumnNames
    {       
        public const string COLUMN_NAME_FIRSTNAME = "FirstName";
        public const string COLUMN_NAME_LASTNAME = "LastName";
        public const string COLUMN_NAME_STATUSTYPE = "Status";
    }

    public static class ExportFileSettings
    {
        public const string FILE_TYPE = "application/xlsx";
        public const string FILE_PATH = "../Shared/Reports/";
        public const string FILE_NAME = "Report.xlsx";
    }
}
