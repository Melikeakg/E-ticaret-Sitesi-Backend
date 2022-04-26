using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //Genel bağımlılıkları yükleyecek
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
