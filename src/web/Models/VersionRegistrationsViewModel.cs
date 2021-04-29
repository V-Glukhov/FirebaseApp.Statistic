namespace StatisticUI.Models
{
    /// <summary>
    /// Модель для отображения статистики по версии
    /// </summary>
    public class VersionRegistrationsViewModel
    {
        /// <summary>
        /// версия мобильного приложения
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// количество регистраций 
        /// </summary>
        public ulong RegistrationCount { get; set; }

        /// <summary>
        /// количество уникальных номеров телефонов 
        /// </summary>
        public ulong UniquePhonesNumbers { get; set; }
    }
}
