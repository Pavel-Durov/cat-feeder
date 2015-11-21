
using CatFeedeer.Core.ViewModels;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;

namespace CatFeedeer.Core
{

    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {


        public override void Initialize()
        {

            CreatableTypes()
                .EndingWith("Service")
                .AsTypes()
                .RegisterAsSingleton();


            RegisterAppStart<FirstViewModel>();

        }
    }
}