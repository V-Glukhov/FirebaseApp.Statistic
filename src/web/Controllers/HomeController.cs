using Microsoft.AspNetCore.Mvc;
using StatisticUI.Models;
using System.Collections.Generic;
using System.Diagnostics;
using X.PagedList;

namespace StatisticUI.Controllers
{
    /// <summary>
    /// Веб-сайт статистики
    /// </summary>
    public class HomeController : Controller
    {
        private List<MessageInfoViewModel> messages = new List<MessageInfoViewModel>
        {
            new MessageInfoViewModel{ Text = "Text1"},
            new MessageInfoViewModel{ Text = "Text2"},
            new MessageInfoViewModel{ Text = "Text3"},
            new MessageInfoViewModel{ Text = "Text4"},
            new MessageInfoViewModel{ Text = "Text5"},
            new MessageInfoViewModel{ Text = "Text6"},
            new MessageInfoViewModel{ Text = "Text7"},
            new MessageInfoViewModel{ Text = "Text8"},
            new MessageInfoViewModel{ Text = "Text9"},
            new MessageInfoViewModel{ Text = "Text10"},
        };

        public HomeController()
        {
        }

        /// <summary>
        /// Стартовая страница
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Отображение списка всех зарегистрированных в системе версий мобильного приложения
        /// </summary>
        /// <returns></returns>
        public IActionResult Registrations()
        {
            return View(new RegistrationsViewModel
            {
                Versions = new VersionRegistrationsViewModel[]
                {
                    new VersionRegistrationsViewModel
                    {
                        Version = "1.0",
                        RegistrationCount = 1005674,
                        UniquePhonesNumbers = 57896784
                    },
                    new VersionRegistrationsViewModel
                    {
                        Version = "1.1",
                        RegistrationCount = 1005674,
                        UniquePhonesNumbers = 57896784
                    }
                }
            });
        }

        /// <summary>
        /// Отображения списка (с пейджингом) всех сообщений, ранее отправленных на указанный номер телефона
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public IActionResult Messages(string phone, int? page = 1)
        {
            int pageSize = 3;
            int pageNumber = page ?? 1;

            return View(messages.ToPagedList(pageNumber, pageSize));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
