using CatFeedeer.Core.Constants;
using CatFeedeer.Core.Services;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Gpio;

namespace CatFeedeer.Core.ViewModels
{
    class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
            Init();
        }

        private void Init()
        {
            _boardService = Mvx.Resolve<FoodManagerService>();
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            RaisePropertyChanged(() => Greetings);
        }
        public string Greetings { get { return "Hello from Core..."; } }



        bool _lightSwitch;

        FoodManagerService _boardService;

        #region Commands

        ICommand _lightSwitchCommand;

        public ICommand LightSwitchCommand
        {
            get
            {
                if (_lightSwitchCommand == null)
                {
                    _lightSwitchCommand = new MvxCommand(() =>
                    {
                        _boardService.TurnFoodEngine(_lightSwitch);
                        _lightSwitch = !_lightSwitch;
                    });
                }
                return _lightSwitchCommand;

            }
        }

        #endregion
    }
}
