using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FileUploadDragDropAutoController : FineUI.Core.Examples.MVC.Controllers.BaseUploadController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult filePhotos_FileSelected(List<IFormFile> filePhotos)
        {
            var upload = UIHelper.FileUpload("filePhotos");
            // 先校验整批。例如第二张图片超过 2 MB 时保留两张图片，让用户重新选择。
            foreach (var file in filePhotos)
            {
                if (!ValidateUploadFile(file, out string error))
                {
                    upload.MarkInvalid($"{file.FileName}（{error}）");
                    return UIHelper.Result();
                }
            }

            UIHelper.Label("labResult").Text("服务器收到：" + string.Join("、", filePhotos.Select(file => file.FileName)));
            upload.Reset();
            return UIHelper.Result();
        }
    }
}
