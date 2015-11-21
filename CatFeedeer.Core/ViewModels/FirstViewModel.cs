using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFeedeer.Core.ViewModels
{
    class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
            test();
        }

        private void test()
        {
           
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            RaisePropertyChanged(() => Greetings);
        }
        public string Greetings{ get { return "Hello from Core..."; } }
    }
}
