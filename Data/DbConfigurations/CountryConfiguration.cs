﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCBookingFinal_YARAB_.Data.DbConfigurations
{
	public class CountryConfiguration : IEntityTypeConfiguration<Country>
	{
		public void Configure(EntityTypeBuilder<Country> builder)
		{
			builder.Property(h => h.isDeleted).HasDefaultValue(false);
			builder.HasData(new Country()
			{ 
				Id = 1,
				Image = "393793e4-337e-4d43-8e2e-54093aa8bc34.png",
				Name = "Egypt"
			});
		}
	}

}
