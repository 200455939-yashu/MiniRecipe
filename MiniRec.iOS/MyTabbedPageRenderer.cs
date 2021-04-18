using System;
using System.Threading.Tasks;
using FFImageLoading;
using FFImageLoading.Svg.Platform;
using MiniRec.Views;
using MiniRec.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedMainPage), typeof(MyTabbedPageRenderer))]
namespace MiniRec.iOS {
    public class MyTabbedPageRenderer : TabbedRenderer {

        protected override async Task<Tuple<UIImage, UIImage>> GetIcon(Page page) {
            UIImage imageIcon;

            if(page.IconImageSource is FileImageSource fileImage && fileImage.File.Contains(".svg")) {
                // Load SVG from file
                UIImage uiImage = await ImageService.Instance.LoadFile(fileImage.File)
                    .WithCustomDataResolver(new SvgDataResolver(15, 15, true))
                    .AsUIImageAsync();
                imageIcon = uiImage.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            } else {
                // Load Xamarin.Forms supported image
                IImageSourceHandler sourceHandler = null;
                if(page.IconImageSource is UriImageSource)
                    sourceHandler = new ImageLoaderSourceHandler();
                else if(page.IconImageSource is FileImageSource)
                    sourceHandler = new FileImageSourceHandler();
                else if(page.IconImageSource is StreamImageSource)
                    sourceHandler = new StreamImagesourceHandler();
                else if(page.IconImageSource is FontImageSource)
                    sourceHandler = new FontImageSourceHandler();

                UIImage uiImage = await sourceHandler.LoadImageAsync(page.IconImageSource);
                imageIcon = uiImage.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
            }

            return new Tuple<UIImage, UIImage>(imageIcon, null);
        }

        public override void ViewDidLayoutSubviews() {
            base.ViewDidLayoutSubviews();

            if(Element is TabbedPage)
                if(TabBar?.Items != null)
                    for(int i = 0; i < TabBar.Items.Length; i++)
                        TabBar.Items[i].ImageInsets = new UIEdgeInsets(4, 4, 4, 4);
        }

    }
}

/*
 * Code from https://www.davidbritch.com/2020/11/display-svgs-as-tabbedpage-tab-icons-in.html
 * https://forums.xamarin.com/discussion/44069/tab-bar-icon-sizing
 */