﻿using DataModel.Models;
using System.Data.Entity;


namespace DataAccess
{
	public class HTShopDbContext : DbContext
	{
		public HTShopDbContext() : base("HTShopConnection")
		{
			
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Error> Errors { get; set; }
		public DbSet<Footer> Footers { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<MenuGroup> MenuGroups { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> GetOrderDetails { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<PostCategory> PostCategories { get; set; }
		public DbSet<PostTag> PostTags { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductTag> ProductTags { get; set; }
		public DbSet<Slide> Slides { get; set; }
		public DbSet<SupportOnline> SupportOnlines { get; set; }
		public DbSet<SystemConfig> SystemConfigs { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
		public DbSet<TanTests> TanTests { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
