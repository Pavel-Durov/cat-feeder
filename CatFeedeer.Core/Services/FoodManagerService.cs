using Cirrious.CrossCore;

namespace CatFeedeer.Core.Services
{
    public class FoodManagerService
    {
        public FoodManagerService()
        {
            _boardService = Mvx.Resolve<PhisicalBoardService>();
        }

        #region 

        PhisicalBoardService _boardService;

        #endregion



        public void TurnFoodEngine(bool state)
        {
            _boardService.SignalOutputPin(PhisicalBoardService.FOOD_ENGINE_PIN, state);
        }


    }
}
