using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    /// <summary>
    /// 数据模型编辑实体。
    ///
    /// <para>
    /// 回发时模型绑定器新建的对象是个<b>空壳</b>，只承载页面里声明过、且客户端回传得来的那几个值，
    /// 与数据源没有任何关系。所以保存不能直接拿它整对象写回（没进表单的属性都是默认值，会把已有数据清零），
    /// 而要<b>按主键重新读出实体、只覆盖表单里出现过的字段</b>。
    /// </para>
    /// </summary>
    [Area("DataModel")]
    public class StudentEditController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/StudentEdit?id=101
        public IActionResult Index(int id)
        {
            var student = StudentStore.Find(id);
            if (student == null)
            {
                // 中止本次请求：不渲染本页，改渲染框架内置极简页并弹出提示。
                // 本页常被窗体以 IFrame 弹出，故让用户点「确定」后顺手关掉父级窗体。
                return UIHelper.AbortPage("该学生不存在或已被删除！", ActiveWindow.GetHideReference());
            }

            // 真实项目在此判断当前用户能不能编辑这条记录，无权则同样 return UIHelper.AbortPage(...)。
            // ⚠️ 注意这里只在首屏执行——回发走 btnSave_Click，所以鉴权在那里还要再做一次。
            // 本示例数据无归属关系，故只留说明。
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSave_Click([Bind("Id", "Name", "Gender", "EntranceYear", "AtSchool", "Major", "EntranceDate")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return UIHelper.Result();
            }

            // 按主键重新读出完整实体，只覆盖表单里出现过的字段；
            // 未列出的属性（分组 / 状态 / 爱好 / 家庭信息 / 成绩）保持原值。
            // 这份清单必须与页面里的字段保持一致——往表单加字段而忘了补赋值，该字段就永远保存不上。
            // 主键由页面上的隐藏字段随回发带回、可被客户端篡改成任意值——回发路径不经过 Index，
            // 所以「当前用户能不能编辑这条记录」必须在这里再判一次（真实项目：无权则 ShowNotify + return）。
            var stored = StudentStore.Find(student.Id);
            if (stored == null)
            {
                ShowNotify("该学生不存在或已被删除！", MessageBoxIcon.Error);
                return UIHelper.Result();
            }

            stored.Name = student.Name;
            stored.Gender = student.Gender;
            stored.EntranceYear = student.EntranceYear;
            stored.AtSchool = student.AtSchool;
            stored.Major = student.Major;
            stored.EntranceDate = student.EntranceDate;

            StudentStore.Update(stored);
            ShowNotify(String.Format("保存成功！ID={0}，姓名={1}", stored.Id, stored.Name), MessageBoxIcon.Success);

            return UIHelper.Result();
        }
    }
}
