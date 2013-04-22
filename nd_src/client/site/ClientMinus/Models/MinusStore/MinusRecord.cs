using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// Model That represents voiced-off record http://bitbucket.org/foomor/minus/wiki/MinusArhcive
    /// </summary>
    public class MinusRecord
    {
        public string User { get; set; }
        
        [Display(Name = "Файл")]
        public FileType File { get; set; }

        [StringLength(255)]
        [Display(Name = "Назва",Description = "Назва композиції")]
        public string Title { get; set; }

        [Display(Name = "Народна композиція")]
        public bool IsFolk { get; set; }

        [Display(Name = "Альтернативний запис",Description = "запис не є українською мінусовкою,(інструменталки, пісні народів світу, тощо)")]
        public bool Alternative { get; set; }

        [Display(Name = "Виконавець")]
        public string Author { get; set; }

        [Display(Name = "Автор аранжування")]
        public string Arrangeuathor { get; set; }

        [Display(Name = "Анотація", Description = "Додаткові дані, авторські права")]
        public string Annotation { get; set; }

        [Display(Name = "Категорії", Description = "Жанри до яких належить даний запис.")]
        public List<object> Categories { get; set; }

        [StringLength(30)]
        [Display(Name = "Тематика", Description = "Тематика даної композиції, наприклад: повстанська, стрілецька, поховальна")]
        public string Thematics { get; set; }

        [Display(Name = "Темп композиції")]
        public Temp Tempo { get; set; }

        [Display(Name = "Виконавчий склад", Description = "колектив, для якого призначена дана мінусовка")]
        public Staff Staff { get; set; }

        [Display(Name = "Стать виконавця")]
        public Gender Gender { get; set; }

        [Display(Name = "Дитяча")]
        public bool IsChildish { get; set; }

        [Display(Name = "Аматорська", Description = "Дана композиція є аматорським записом")]
        public bool IsAmateur { get; set; }

        [Display(Name = "Обрядова", Description = "Виконується на весіллях, святах і т.п.")]
        public bool IsRitual { get; set; }

        [Display(Name = "Текст пісні")]
        public string Lyrycs { get; set; }

        [Display(Name = "Посилання на плюсовку",Description = "Посилання на файло-обмінник або інше місце, звідки можна скачати оригінал")]
        public string PlusRecord { get; set; }

        public DateTime PublicDate { get; set; }

        public object Length { get; set; }

        public int Bitrate { get; set; }

        public int FileSize { get; set; }

        [Display(Name = "Відео виконання", Description = "За бажанням можете вставити відео з оригінальним виконанням композиції. Підтримувані сервіси: youtube',")]
        public string EmbedVideo { get; set; }

        public string Type { get; set; }

        [Display(Name = "Рейтинг")]
        public int Rating { get; set; }

    }
}