﻿using System;
using System.Globalization;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace ArtHistory
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            string text = "\r\n\r\nИзобразительное искусство — это способ выражения чувств, мыслей и идей через визуальные образы. Оно охватывает всё, что можно нарисовать, слепить, изготовить или соорудить, чтобы передать впечатление. Живопись, графика, скульптура — это классические примеры изобразительного искусства. При этом не менее важны и такие формы, как фотография, инсталляция или видеоарт. Художник пользуется кистями, красками, глиной, камнем, цифровыми инструментами — всем, что поможет воплотить замысел. Так, изобразительное искусство становится языком, на котором разговаривают цвета и формы.\r\n\r\nПриходя в галерею или музей, мы погружаемся в мир изобразительного искусства. Это как будто читаешь книгу, где каждая страница — это картина или скульптура. Она рассказывает свою уникальную историю, будь то любовь, гнев, радость или печаль. Художник, как писатель, выбирает жанр — портрет, пейзаж, натюрморт и другие, чтобы лучше донести свою мысль. Есть и авангард, где все традиционные правила оставлены позади, а главное — это новаторство. Истории, зашифрованные в художественных образах, способны вызвать мощный эмоциональный отклик.\r\n\r\nЧасто изобразительное искусство служит мостом между прошлым и будущим. В нём отражена история эпох, культурных традиций, социальных изменений. Искусство античности отличается от средневекового, а ренессанс привнёс свои идеалы красоты и гармонии. Модернизм начала XX века перевернул представление о картинах и скульптуре. Постмодернизм же показал, что в искусстве нет чётких границ. Изменились техники, материалы, но желание чего-то выразить осталось неизменным.\r\n\r\nИзобразительное искусство — это не только картины на стенах музеев. Это и уличное граффити, и детские рисунки на холодильнике. В каждом из этих проявлений скрыт смысл и красота. Понять это искусство может не каждый, но ощутить его воздействие под силу всем. Обычно оно говорит не о чём-то одном, а заставляет задуматься о многих вещах. И по-настоящему хорошее изобразительное искусство никогда не устареет.\r\n\r\nИногда изобразительное искусство кажется непонятным, как странный знак или символ. Но в этом и есть его магия — вызывать вопросы, заставлять искать ответы. Художник может не рассказать нам всю историю, оставляя пространство для фантазии. Мы можем видеть в одних и тех же картинах совершенно разные истории. Это и есть то самое волшебство, которое и притягивает любителей искусства. Изобразительное искусство напоминает нам о том, что в мире существует место для множества точек зрения.\r\n\r\nВ мире изобразительного искусства есть определенные направления и стили. Каждый из них нашел свою аудиторию, свой способ воздействия на зрителя. Импрессионизм восхищает легкостью и воздушностью мазков. Экспрессионизм потрясает эмоциональной силой и страстью. Кубизм разрушает привычное видение мира, собирая его из геометрических фигур. Сюрреализм же выносит наружу сны и бессознательное. Таким образом, каждое направление искусства открывает перед нами новую грань реальности.";
            
            // Вставляем FlowDocument в RichTextBox
            RTB.AppendText(text);

        }
    }
}
