using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Services
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof
				(ServiceRegistration).Assembly));

			//bu noktada artık IMediator 'u ctor içerisinde gectiğimiz her yerde gecerli olacak.
			//ve controller 'lar içerisinde tek tek handler 'ların inject edilmesinin önüne gecmiş olucam
		}
	}
}
