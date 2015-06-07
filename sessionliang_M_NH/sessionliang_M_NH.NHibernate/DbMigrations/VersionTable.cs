using FluentMigrator.VersionTableInfo;

namespace sessionliang_M_NH.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "MyAppVersionInfo";
            }
        }
    }
}
