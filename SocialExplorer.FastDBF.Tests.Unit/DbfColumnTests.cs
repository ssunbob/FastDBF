using SocialExplorer.IO.FastDBF;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SocialExplorer.FastDBF.Tests.Unit
{
    public class DbfColumnTests
    {
        #region -- Constructor tests --
        [Fact]
        public void DbfColumn_Construct_NameNull_ThrowsException()
        {
            var ex = Assert.Throws<Exception>(() => new DbfColumn(null, default(DbfColumn.DbfColumnType)));
            Assert.Equal("Field names must be at least one char long and can not be null.", ex.Message);
        }

        [Fact]
        public void DbfColumn_Construct_NameEmpty_ThrowsException()
        {
            var ex = Assert.Throws<Exception>(() => new DbfColumn(String.Empty, default(DbfColumn.DbfColumnType)));
            Assert.Equal("Field names must be at least one char long and can not be null.", ex.Message);
        }

        [Fact]
        public void DbfColumn_Construct_NameLongerThan11Chars_ThrowsException()
        {
            var ex = Assert.Throws<Exception>(() => new DbfColumn("TheseAreMoreThan11Chars", default(DbfColumn.DbfColumnType)));
            Assert.Equal("Field names can not be longer than 11 chars.", ex.Message);
        }

        [Fact]
        public void DbfColumn_Construct_DbfColumnTypeNumber_NoLenghtNorDecimalPrecisionSpecified2_ThrowsException()
        {
            var ex = Assert.Throws<Exception>(() => new DbfColumn("COLUMN", DbfColumn.DbfColumnType.Number, 0, 0));
            Assert.Equal("Invalid field length specified. Field length can not be zero or less than zero.", ex.Message);
        }

        [Fact]
        public void DbfColumn_Construct_DbfColumnTypeNumber_LenghtBiggerThanDecimalPrecision_ThrowsException()
        {
            var ex = Assert.Throws<Exception>(() => new DbfColumn("COLUMN", DbfColumn.DbfColumnType.Number, 1, 2));
            Assert.Equal("Decimal precision can not be larger than the length of the field.", ex.Message);
        }
        #endregion
    }
}
