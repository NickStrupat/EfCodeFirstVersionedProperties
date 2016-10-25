﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

#if EF_CORE
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.VersionedProperties {
#else
using System.Data.Entity;
using System.Data.Entity.Spatial;
namespace EntityFramework.VersionedProperties {
#endif
#if !EF_CORE
	[ComplexType]
	public sealed class VersionedDbGeometry : VersionedBase<DbGeometry, DbGeometryVersion, IDbGeometryVersions> {
		protected override Func<IDbGeometryVersions, DbSet<DbGeometryVersion>> VersionDbSet => x => x.DbGeometryVersions;
	}
#endif
}