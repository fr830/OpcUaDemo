using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongFang.OpcUa.Client
{
    /// <summary>
    /// 异常辅助类
    /// </summary>
    public class ExceptionHelper
    {
        
        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="caption">标题</param>
        /// <param name="e"><see cref="Exception"/>对象</param>
        public static void HandleException(string caption, Exception e)
        {
            ShowExceptionDlg(caption, e);
        }

        /// <summary>
        /// 显示异常处理对话框
        /// </summary>
        /// <param name="caption">标题</param>
        /// <param name="e"><see cref="Exception"/>对象</param>
        public static void ShowExceptionDlg(string caption, Exception e)
        {
            if (!Environment.UserInteractive)
            {
                Utils.Trace(e, "Unexpected error in '{0}'.", caption);
                return;
            }
            new ExceptionDlg().ShowDialog(caption, e);
        }
    }
}
