namespace StatisticUI.Models
{
    /// <summary>
    ///  Модель для отображения статистики по версиям
    /// </summary>
    public class RegistrationsViewModel
    {
        /// <summary>
        /// Данные статистики
        /// </summary>
        public VersionRegistrationsViewModel[] Versions { get; set; }
    }
}
