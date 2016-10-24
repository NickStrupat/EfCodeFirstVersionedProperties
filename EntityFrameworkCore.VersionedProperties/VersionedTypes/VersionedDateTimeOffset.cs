using System;
using System.ComponentModel.DataAnnotations.Schema;

#if EF_CORE
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.VersionedProperties {
#else
using System.Data.Entity;
namespace EntityFramework.VersionedProperties {
#endif
	[ComplexType]
	public sealed class VersionedDateTimeOffset : VersionedBase<DateTimeOffset, DateTimeOffsetVersion, IDateTimeOffsetVersions> {
		protected override Func<IDateTimeOffsetVersions, DbSet<DateTimeOffsetVersion>> VersionDbSet => x => x.DateTimeOffsetVersions;
	}
}