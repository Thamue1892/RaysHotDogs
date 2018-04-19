using Android.App;
using Android.Views;
using Android.Widget;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Utility;
using System.Collections.Generic;

namespace RaysHotDogs.Adapters
{
    public class HotDogListAdapter : BaseAdapter<HotDog>
    {
        private List<HotDog> items;
        private Activity context;

        public HotDogListAdapter(Activity context, List<HotDog> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override HotDog this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            //if (convertView==null)
            //{
            //    convertView = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            //}
            var imageBitmap = ImageHelper.GetImageBitmapFromUrl("http://gillcleerenpluralsight.blob.core.windows.net/files/" + item.ImagePath + ".jpg");

            if (convertView == null)
            {
                convertView =
                    context.LayoutInflater
                        .Inflate(Android.Resource.Layout.ActivityListItem, null);
            }

            convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Name;
            convertView.FindViewById<ImageView>(Android.Resource.Id.Icon)
                .SetImageBitmap(imageBitmap);

            return convertView;
        }
    }
}