using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static IServiceCollection ContainerDependencies(this IServiceCollection services)
		{

			services.AddScoped<IHomeService, HomeManager>();
			services.AddScoped<IHomeDal, EfHomeDal>();
			services.AddScoped<IHomeContentService, HomeContentManager>();
			services.AddScoped<IHomeContentDal, EfHomeContentDal>();
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IAboutDal, EfAboutDal>();
			services.AddScoped<IStoreService, StoreManager>();
			services.AddScoped<IStoreDal, EfStoreDal>();
			services.AddScoped<IAddressService, AddressManager>();
			services.AddScoped<IAddressDal, EfAddressDal>();
			services.AddScoped<IProductService, ProductManager>();
			services.AddScoped<IProductDal, EfProductDal>();
			return services;
		}
	}
}
