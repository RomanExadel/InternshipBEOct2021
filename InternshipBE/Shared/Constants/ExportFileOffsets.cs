namespace Shared.Constants
{
    public static class ExportFileOffsets
    {
        public const string INTERNSHIP_VALUE_OFFSET = "B1";
        public const string CANDIDATE_COUNT_VALUE_OFFSET = "B2";
        public const string CANDIDATE_COUNT_NAME_OFFSET = "A2";
        public const string NAME_DATE_REPORT_OFFSET = "A3";
        public const string DATE_REPORT_OFFSET = "B3";
        public const string STYLE_RANGE_OFFSET = "A1:A3";
        public const string STYLE_RANGE_ARRAY_NAME_OFFSET = "A5:K5";
        public const int INTERNSHIP_NAME_COLUMN_OFFSET = 1;
        public const int INTERNSHIP_NAME_ROW_OFFSET = 1;
        
    }

    public static class ExportFileColumnNames
    {       
        public const string COLUMN_NAME_FIRSTNAME = "FirstName";
        public const string COLUMN_NAME_LASTNAME = "LastName";       
        public const string COLUMN_NAME_DATE_REGISTRATION = "Date registration";
        public const string COLUMN_NAME_LOCATION = "Location";
        public const string COLUMN_NAME_INTERNSHIP_LANGUAGE = "Internship language";
        public const string COLUMN_NAME_STACK = "Stack";
        public const string COLUMN_NAME_ENGLISH_LVL = "English level";
        public const string COLUMN_NAME_PHONE = "Phone";
        public const string COLUMN_NAME_EMAIL = "Email";
        public const string COLUMN_NAME_SKYPE = "Skype";
        public const string COLUMN_NAME_STATUSTYPE = "Status";
    }

    public static class ExportFileSettings
    {
        public const string FILE_TYPE = "application/xlsx";
        public const string FILE_NAME = "Report.xlsx";
    }
}
