using Android.App;
using Android.OS;
using Android.Widget;
using RaysHotDogs.Adapters;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;
using System.Collections.Generic;

namespace RaysHotDogs
{
    [Activity(Label = "Hot Dog Menu", MainLauncher = true)]
    public class HotDogMenuActivity : Activity
    {
        private ListView hotDogListView;
        private List<HotDog> allHotDogs;
        private HotDogDataService hotDogDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.HotDogMenuView);

            hotDogListView = FindViewById<ListView>(Resource.Id.hotDogListView);

            hotDogDataService = new HotDogDataService();

            allHotDogs = hotDogDataService.GetAllHotDogs();

            hotDogListView.Adapter = new HotDogListAdapter(this, allHotDogs);

            hotDogListView.FastScrollEnabled = true;
        }
    }
}