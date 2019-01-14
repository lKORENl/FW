﻿using System.Collections;
using System.Collections.Generic;


public class Animals 
{
    public List<Word> words;

    public Animals()
    {
        words = new List<Word>
        {
        new Word { id =1,callNumber =0,numberOfLetters =2,word = "Уж",  description = ""},
        new Word { id =2,callNumber =0,numberOfLetters =2,word = "Ёж",  description = ""},
        new Word { id =3,callNumber =0,numberOfLetters =3,word = "Ёрш",  description = ""},
        new Word { id =4,callNumber =0,numberOfLetters =3,word = "Лев",  description = ""},
        new Word { id =5,callNumber =0,numberOfLetters =3,word = "Тур",  description = ""},
        new Word { id =6,callNumber =0,numberOfLetters =3,word = "Рак",  description = ""},
        new Word { id =7,callNumber =0,numberOfLetters =3,word = "Жук",  description = ""},
        new Word { id =8,callNumber =0,numberOfLetters =3,word = "Оса",  description = ""},
        new Word { id =9,callNumber =0,numberOfLetters =3,word = "Сыч",  description = ""},
        new Word { id =10  ,callNumber =0,numberOfLetters =3,word = "Тля",  description = ""},
        new Word { id =11  ,callNumber =0,numberOfLetters =4,word = "Гриф",  description = ""},
        new Word { id =12  ,callNumber =0,numberOfLetters =4,word = "Енот",  description = ""},
        new Word { id =13  ,callNumber =0,numberOfLetters =4,word = "Жаба",  description = ""},
new Word { id =14  ,callNumber =0,numberOfLetters =4,word = "Змея",  description = ""},
new Word { id =15  ,callNumber =0,numberOfLetters =4,word = "Киви",  description = ""},
new Word { id =16  ,callNumber =0,numberOfLetters =4,word = "Краб",  description = ""},
new Word { id =17  ,callNumber =0,numberOfLetters =4,word = "Лось",  description = ""},
new Word { id =18  ,callNumber =0,numberOfLetters =4,word = "Моль",  description = ""},
new Word { id =19  ,callNumber =0,numberOfLetters =4,word = "Овод",  description = ""},
new Word { id =20  ,callNumber =0,numberOfLetters =4,word = "Орёл",  description = ""},
new Word { id =21  ,callNumber =0,numberOfLetters =4,word = "Осёл",  description = ""},
new Word { id =22  ,callNumber =0,numberOfLetters =4,word = "Рысь",  description = ""},
new Word { id =23  ,callNumber =0,numberOfLetters =4,word = "Слон",  description = ""},
new Word { id =24  ,callNumber =0,numberOfLetters =4,word = "Удав",  description = ""},
new Word { id =25  ,callNumber =0,numberOfLetters =4,word = "Усач",  description = ""},
new Word { id =26  ,callNumber =0,numberOfLetters =4,word = "Волк",  description = ""},
new Word { id =27  ,callNumber =0,numberOfLetters =4,word = "Гага",  description = ""},
new Word { id =28  ,callNumber =0,numberOfLetters =4,word = "Заяц",  description = ""},
new Word { id =29  ,callNumber =0,numberOfLetters =4,word = "Ибис",  description = ""},
new Word { id =30  ,callNumber =0,numberOfLetters =4,word = "Клещ",  description = ""},
new Word { id =31  ,callNumber =0,numberOfLetters =4,word = "Лань",  description = ""},
new Word { id =32  ,callNumber =0,numberOfLetters =4,word = "Муха",  description = ""},
new Word { id =33  ,callNumber =0,numberOfLetters =4,word = "Ткач",  description = ""},
new Word { id =34  ,callNumber =0,numberOfLetters =4,word = "Хрущ",  description = ""},
new Word { id =35  ,callNumber =0,numberOfLetters =4,word = "Ящер",  description = ""},
new Word { id =36  ,callNumber =0,numberOfLetters =4,word = "Бобр",  description = ""},
new Word { id =37  ,callNumber =0,numberOfLetters =4,word = "Зубр",  description = ""},
new Word { id =38  ,callNumber =0,numberOfLetters =4,word = "Крот",  description = ""},
new Word { id =39  ,callNumber =0,numberOfLetters =4,word = "Лама",  description = ""},
new Word { id =40  ,callNumber =0,numberOfLetters =4,word = "Мышь",  description = ""},
new Word { id =41  ,callNumber =0,numberOfLetters =4,word = "Овца",  description = ""},
new Word { id =42  ,callNumber =0,numberOfLetters =4,word = "Паук",  description = ""},
new Word { id =43  ,callNumber =0,numberOfLetters =4,word = "Скат",  description = ""},
new Word { id =44  ,callNumber =0,numberOfLetters =4,word = "Сова",  description = ""},
new Word { id =45  ,callNumber =0,numberOfLetters =4,word = "Тигр",  description = ""},
new Word { id =46  ,callNumber =0,numberOfLetters =5,word = "Бизон",  description = ""},
new Word { id =47  ,callNumber =0,numberOfLetters =5,word = "Варан",  description = ""},
new Word { id =48  ,callNumber =0,numberOfLetters =5,word = "Выдра",  description = ""},
new Word { id =49  ,callNumber =0,numberOfLetters =5,word = "Дрофа",  description = ""},
new Word { id =50  ,callNumber =0,numberOfLetters =5,word = "Жираф",  description = ""},
new Word { id =51  ,callNumber =0,numberOfLetters =5,word = "Зебра",  description = ""},
new Word { id =52  ,callNumber =0,numberOfLetters =5,word = "Кабан",  description = ""},
new Word { id =53  ,callNumber =0,numberOfLetters =5,word = "Кобра",  description = ""},
new Word { id =54  ,callNumber =0,numberOfLetters =5,word = "Крыса",  description = ""},
new Word { id =55  ,callNumber =0,numberOfLetters =5,word = "Окунь",  description = ""},
new Word { id =56  ,callNumber =0,numberOfLetters =5,word = "Судак",  description = ""},
new Word { id =57  ,callNumber =0,numberOfLetters =5,word = "Хомяк",  description = ""},
new Word { id =58  ,callNumber =0,numberOfLetters =5,word = "Шмель",  description = ""},
new Word { id =59  ,callNumber =0,numberOfLetters =5,word = "Кулик",  description = ""},
new Word { id =60  ,callNumber =0,numberOfLetters =5,word = "Акула",  description = ""},
new Word { id =61  ,callNumber =0,numberOfLetters =5,word = "Баран",  description = ""},
new Word { id =62  ,callNumber =0,numberOfLetters =5,word = "Ворон",  description = ""},
new Word { id =63  ,callNumber =0,numberOfLetters =5,word = "Губка",  description = ""},
new Word { id =64  ,callNumber =0,numberOfLetters =5,word = "Дятел",  description = ""},
new Word { id =65  ,callNumber =0,numberOfLetters =5,word = "Козёл",  description = ""},
new Word { id =66  ,callNumber =0,numberOfLetters =5,word = "Конёк",  description = ""},
new Word { id =67  ,callNumber =0,numberOfLetters =5,word = "Лемур",  description = ""},
new Word { id =68  ,callNumber =0,numberOfLetters =5,word = "Мамба",  description = ""},
new Word { id =69  ,callNumber =0,numberOfLetters =5,word = "Осётр",  description = ""},
new Word { id =70  ,callNumber =0,numberOfLetters =5,word = "Панда",  description = ""},
new Word { id =71  ,callNumber =0,numberOfLetters =5,word = "Питон",  description = ""},
new Word { id =72  ,callNumber =0,numberOfLetters =5,word = "Сойка",  description = ""},
new Word { id =73  ,callNumber =0,numberOfLetters =5,word = "Тунец",  description = ""},
new Word { id =74  ,callNumber =0,numberOfLetters =5,word = "Цапля",  description = ""},
new Word { id =75  ,callNumber =0,numberOfLetters =5,word = "Шпрот",  description = ""},
new Word { id =76  ,callNumber =0,numberOfLetters =5,word = "Щучка",  description = ""},
new Word { id =77  ,callNumber =0,numberOfLetters =5,word = "Ягуар",  description = ""},
new Word { id =78  ,callNumber =0,numberOfLetters =5,word = "Белка",  description = ""},
new Word { id =79  ,callNumber =0,numberOfLetters =5,word = "Вобла",  description = ""},
new Word { id =80  ,callNumber =0,numberOfLetters =5,word = "Дрозд",  description = ""},
new Word { id =81  ,callNumber =0,numberOfLetters =5,word = "Комар",  description = ""},
new Word { id =82  ,callNumber =0,numberOfLetters =5,word = "Кошка",  description = ""},
new Word { id =83  ,callNumber =0,numberOfLetters =5,word = "Нанду",  description = ""},
new Word { id =84  ,callNumber =0,numberOfLetters =5,word = "Норка",  description = ""},
new Word { id =85  ,callNumber =0,numberOfLetters =5,word = "Олень",  description = ""},
new Word { id =86  ,callNumber =0,numberOfLetters =5,word = "Полоз",  description = ""},
new Word { id =87  ,callNumber =0,numberOfLetters =5,word = "Пчела",  description = ""},
new Word { id =88  ,callNumber =0,numberOfLetters =5,word = "Сокол",  description = ""},
new Word { id =89  ,callNumber =0,numberOfLetters =5,word = "Стриж",  description = ""},
new Word { id =90  ,callNumber =0,numberOfLetters =5,word = "Сурок",  description = ""},
new Word { id =91  ,callNumber =0,numberOfLetters =5,word = "Филин",  description = ""},
new Word { id =92  ,callNumber =0,numberOfLetters =5,word = "Хорёк",  description = ""},
new Word { id =93  ,callNumber =0,numberOfLetters =5,word = "Чайка",  description = ""},
new Word { id =94  ,callNumber =0,numberOfLetters =6,word = "Анчоус",  description = ""},
new Word { id =95  ,callNumber =0,numberOfLetters =6,word = "Барсук",  description = ""},
new Word { id =96  ,callNumber =0,numberOfLetters =6,word = "Геккон",  description = ""},
new Word { id =97  ,callNumber =0,numberOfLetters =6,word = "Гиббон",  description = ""},
new Word { id =98  ,callNumber =0,numberOfLetters =6,word = "Иволга",  description = ""},
new Word { id =99  ,callNumber =0,numberOfLetters =6,word = "Игуана",  description = ""},
new Word { id =100 ,callNumber =0,numberOfLetters =6,word = "Кайман",  description = ""},
new Word { id =101 ,callNumber =0,numberOfLetters =6,word = "Какаду",  description = ""},
new Word { id =102 ,callNumber =0,numberOfLetters =6,word = "Кондор",  description = ""},
new Word { id =103 ,callNumber =0,numberOfLetters =6,word = "Коршун",  description = ""},
new Word { id =104 ,callNumber =0,numberOfLetters =6,word = "Косуля",  description = ""},
new Word { id =105 ,callNumber =0,numberOfLetters =6,word = "Кролик",  description = ""},
new Word { id =106 ,callNumber =0,numberOfLetters =6,word = "Муфлон",  description = ""},
new Word { id =107 ,callNumber =0,numberOfLetters =6,word = "Страус",  description = ""},
new Word { id =108 ,callNumber =0,numberOfLetters =6,word = "Суслик",  description = ""},
new Word { id =109 ,callNumber =0,numberOfLetters =6,word = "Тюлень",  description = ""},
new Word { id =110 ,callNumber =0,numberOfLetters =6,word = "Ястреб",  description = ""},
new Word { id =111 ,callNumber =0,numberOfLetters =6,word = "Буйвол",  description = ""},
new Word { id =112 ,callNumber =0,numberOfLetters =6,word = "Гадюка",  description = ""},
new Word { id =113 ,callNumber =0,numberOfLetters =6,word = "Гарпия",  description = ""},
new Word { id =114 ,callNumber =0,numberOfLetters =6,word = "Корова",  description = ""},
new Word { id =115 ,callNumber =0,numberOfLetters =6,word = "Крылан",  description = ""},
new Word { id =116 ,callNumber =0,numberOfLetters =6,word = "Куница",  description = ""},
new Word { id =117 ,callNumber =0,numberOfLetters =6,word = "Лебедь",  description = ""},
new Word { id =118 ,callNumber =0,numberOfLetters =6,word = "Летяга",  description = ""},
new Word { id =119 ,callNumber =0,numberOfLetters =6,word = "Лисица",  description = ""},
new Word { id =120 ,callNumber =0,numberOfLetters =6,word = "Сайгак",  description = ""},
new Word { id =121 ,callNumber =0,numberOfLetters =6,word = "Синица",  description = ""},
new Word { id =122 ,callNumber =0,numberOfLetters =6,word = "Собака",  description = ""},
new Word { id =123 ,callNumber =0,numberOfLetters =6,word = "Тюлька",  description = ""},
new Word { id =124 ,callNumber =0,numberOfLetters =6,word = "Улитка",  description = ""},
new Word { id =125 ,callNumber =0,numberOfLetters =6,word = "Гадюка",  description = ""},
new Word { id =126 ,callNumber =0,numberOfLetters =6,word = "Газель",  description = ""},
new Word { id =127 ,callNumber =0,numberOfLetters =6,word = "Гепард",  description = ""},
new Word { id =128 ,callNumber =0,numberOfLetters =6,word = "Голубь",  description = ""},
new Word { id =129 ,callNumber =0,numberOfLetters =6,word = "Ехидна",  description = ""},
new Word { id =130 ,callNumber =0,numberOfLetters =6,word = "Карась",  description = ""},
new Word { id =131 ,callNumber =0,numberOfLetters =6,word = "Катран",  description = ""},
new Word { id =132 ,callNumber =0,numberOfLetters =6,word = "Курица",  description = ""},
new Word { id =133 ,callNumber =0,numberOfLetters =6,word = "Лошадь",  description = ""},
new Word { id =134 ,callNumber =0,numberOfLetters =6,word = "Мурена",  description = ""},
new Word { id =135 ,callNumber =0,numberOfLetters =6,word = "Мухоед",  description = ""},
new Word { id =136 ,callNumber =0,numberOfLetters =6,word = "Павиан",  description = ""},
new Word { id =137 ,callNumber =0,numberOfLetters =6,word = "Сорока",  description = ""},
new Word { id =138 ,callNumber =0,numberOfLetters =6,word = "Кролик",  description = ""},
new Word { id =139 ,callNumber =0,numberOfLetters =7,word = "Бегемот",  description = ""},
new Word { id =140 ,callNumber =0,numberOfLetters =7,word = "Воробей",  description = ""},
new Word { id =141 ,callNumber =0,numberOfLetters =7,word = "Журавль",  description = ""},
new Word { id =142 ,callNumber =0,numberOfLetters =7,word = "Кукушка",  description = ""},
new Word { id =143 ,callNumber =0,numberOfLetters =7,word = "Лангуст",  description = ""},
new Word { id =144 ,callNumber =0,numberOfLetters =7,word = "Ленивец",  description = ""},
new Word { id =145 ,callNumber =0,numberOfLetters =7,word = "Носорог",  description = ""},
new Word { id =146 ,callNumber =0,numberOfLetters =7,word = "Саранча",  description = ""},
new Word { id =147 ,callNumber =0,numberOfLetters =7,word = "Скворец",  description = ""},
new Word { id =148 ,callNumber =0,numberOfLetters =7,word = "Утконос",  description = ""},
new Word { id =149 ,callNumber =0,numberOfLetters =7,word = "Дельфин",  description = ""},
new Word { id =150 ,callNumber =0,numberOfLetters =7,word = "Бабочка",  description = ""},
new Word { id =151 ,callNumber =0,numberOfLetters =7,word = "Горилла",  description = ""},
new Word { id =152 ,callNumber =0,numberOfLetters =7,word = "Дельфин",  description = ""},
new Word { id =153 ,callNumber =0,numberOfLetters =7,word = "Кальмар",  description = ""},
new Word { id =154 ,callNumber =0,numberOfLetters =7,word = "Кенгуру",  description = ""},
new Word { id =155 ,callNumber =0,numberOfLetters =7,word = "Колибри",  description = ""},
new Word { id =156 ,callNumber =0,numberOfLetters =7,word = "Лемминг",  description = ""},
new Word { id =157 ,callNumber =0,numberOfLetters =7,word = "Леопард",  description = ""},
new Word { id =158 ,callNumber =0,numberOfLetters =7,word = "Мангуст",  description = ""},
new Word { id =159 ,callNumber =0,numberOfLetters =7,word = "Муравей",  description = ""},
new Word { id =160 ,callNumber =0,numberOfLetters =7,word = "Опоссум",  description = ""},
new Word { id =161 ,callNumber =0,numberOfLetters =7,word = "Пингвин",  description = ""},
new Word { id =162 ,callNumber =0,numberOfLetters =7,word = "Полёвка",  description = ""},
new Word { id =163 ,callNumber =0,numberOfLetters =7,word = "Попугай",  description = ""},
new Word { id =164 ,callNumber =0,numberOfLetters =7,word = "Сверчок",  description = ""},
new Word { id =165 ,callNumber =0,numberOfLetters =7,word = "Соловей",  description = ""},
new Word { id =166 ,callNumber =0,numberOfLetters =7,word = "Верблюд",  description = ""},
new Word { id =167 ,callNumber =0,numberOfLetters =7,word = "Глухарь",  description = ""},
new Word { id =168 ,callNumber =0,numberOfLetters =7,word = "Горлица",  description = ""},
new Word { id =169 ,callNumber =0,numberOfLetters =7,word = "Индейка",  description = ""},
new Word { id =170 ,callNumber =0,numberOfLetters =7,word = "Косатка",  description = ""},
new Word { id =171 ,callNumber =0,numberOfLetters =7,word = "Лягушка",  description = ""},
new Word { id =172 ,callNumber =0,numberOfLetters =7,word = "Пеликан",  description = ""},
new Word { id =173 ,callNumber =0,numberOfLetters =7,word = "Перепел",  description = ""},
new Word { id =174 ,callNumber =0,numberOfLetters =7,word = "Слизень",  description = ""},
new Word { id =175 ,callNumber =0,numberOfLetters =7,word = "Снегирь",  description = ""},
new Word { id =176 ,callNumber =0,numberOfLetters =7,word = "Таракан",  description = ""},
new Word { id =177 ,callNumber =0,numberOfLetters =7,word = "Тетерев",  description = ""},
new Word { id =178 ,callNumber =0,numberOfLetters =7,word = "Устрица",  description = ""},
new Word { id =179 ,callNumber =0,numberOfLetters =7,word = "Ящерица",  description = ""},
new Word { id =180 ,callNumber =0,numberOfLetters =8,word = "Дикобраз",  description = ""},
new Word { id =181 ,callNumber =0,numberOfLetters =8,word = "Древолаз",  description = ""},
new Word { id =182 ,callNumber =0,numberOfLetters =8,word = "Антилопа",  description = ""},
new Word { id =183 ,callNumber =0,numberOfLetters =8,word = "Долгопят",  description = ""},
new Word { id =184 ,callNumber =0,numberOfLetters =8,word = "Стрекоза",  description = ""},
new Word { id =185 ,callNumber =0,numberOfLetters =8,word = "Султанка",  description = ""},
new Word { id =186 ,callNumber =0,numberOfLetters =8,word = "Веслоног",  description = ""},
new Word { id =187 ,callNumber =0,numberOfLetters =8,word = "Крокодил",  description = ""},
new Word { id =188 ,callNumber =0,numberOfLetters =8,word = "Листонос",  description = ""},
new Word { id =189 ,callNumber =0,numberOfLetters =8,word = "Мартышка",  description = ""},
new Word { id =190 ,callNumber =0,numberOfLetters =8,word = "Нетопырь",  description = ""},
new Word { id =191 ,callNumber =0,numberOfLetters =8,word = "Обезьяна",  description = ""},
new Word { id =192 ,callNumber =0,numberOfLetters =8,word = "Скорпион",  description = ""},
new Word { id =193 ,callNumber =0,numberOfLetters =8,word = "Странник",  description = ""},
new Word { id =194 ,callNumber =0,numberOfLetters =8,word = "Удильщик",  description = ""},
new Word { id =195 ,callNumber =0,numberOfLetters =8,word = "Черепаха",  description = ""},
new Word { id =196 ,callNumber =0,numberOfLetters =8,word = "Шишечник",  description = ""},
new Word { id =197 ,callNumber =0,numberOfLetters =9,word = "Безглазка",  description = ""},
new Word { id =198 ,callNumber =0,numberOfLetters =9,word = "Белозубка",  description = ""},
new Word { id =199 ,callNumber =0,numberOfLetters =9,word = "Верблюдка",  description = ""},
new Word { id =200 ,callNumber =0,numberOfLetters =9,word = "Водомерка",  description = ""},
new Word { id =201 ,callNumber =0,numberOfLetters =9,word = "Звездочёт",  description = ""},
new Word { id =202 ,callNumber =0,numberOfLetters =9,word = "Куропатка",  description = ""},
new Word { id =203 ,callNumber =0,numberOfLetters =9,word = "Ленточник",  description = ""},
new Word { id =204 ,callNumber =0,numberOfLetters =9,word = "Мухоловка",  description = ""},
new Word { id =205 ,callNumber =0,numberOfLetters =9,word = "Пестрянка",  description = ""},
new Word { id =206 ,callNumber =0,numberOfLetters =9,word = "Шелкопряд",  description = ""},
new Word { id =207 ,callNumber =0,numberOfLetters =9,word = "Шипохвост",  description = ""},
new Word { id =208 ,callNumber =0,numberOfLetters =9,word = "Барракуда",  description = ""},
new Word { id =209 ,callNumber =0,numberOfLetters =9,word = "Блестянка",  description = ""},
new Word { id =210 ,callNumber =0,numberOfLetters =9,word = "Вилохвост",  description = ""},
new Word { id =211 ,callNumber =0,numberOfLetters =9,word = "Камышовка",  description = ""},
new Word { id =212 ,callNumber =0,numberOfLetters =9,word = "Жаворонок",  description = ""},
new Word { id =213 ,callNumber =0,numberOfLetters =9,word = "Зеленушка",  description = ""},
new Word { id =214 ,callNumber =0,numberOfLetters =9,word = "Иглохвост",  description = ""},
new Word { id =215 ,callNumber =0,numberOfLetters =9,word = "Каменушка",  description = ""},
new Word { id =216 ,callNumber =0,numberOfLetters =9,word = "Крапивник",  description = ""},
new Word { id =217 ,callNumber =0,numberOfLetters =9,word = "Ланцетник",  description = ""},
new Word { id =218 ,callNumber =0,numberOfLetters =9,word = "Малиновка",  description = ""},
new Word { id =219 ,callNumber =0,numberOfLetters =9,word = "Орангутан",  description = ""},
new Word { id =220 ,callNumber =0,numberOfLetters =9,word = "Пеструшка",  description = ""},
new Word { id =221 ,callNumber =0,numberOfLetters =9,word = "Пилильщик",  description = ""},
new Word { id =222 ,callNumber =0,numberOfLetters =9,word = "Радужница",  description = ""},
new Word { id =223 ,callNumber =0,numberOfLetters =9,word = "Щитоноска",  description = ""},
new Word { id =224 ,callNumber =0,numberOfLetters =10  ,word = "Сардинелла",  description = ""},
new Word { id =225 ,callNumber =0,numberOfLetters =10  ,word = "Белокровка",  description = ""},
new Word { id =226 ,callNumber =0,numberOfLetters =10  ,word = "Броненосец",  description = ""},
new Word { id =227 ,callNumber =0,numberOfLetters =10  ,word = "Двухвостка",  description = ""},
new Word { id =228 ,callNumber =0,numberOfLetters =10  ,word = "Желтопузик",  description = ""},
new Word { id =229 ,callNumber =0,numberOfLetters =10  ,word = "Каракатица",  description = ""},
new Word { id =230 ,callNumber =0,numberOfLetters =10  ,word = "Моллюскоед",  description = ""},
new Word { id =231 ,callNumber =0,numberOfLetters =10  ,word = "Веретеница",  description = ""},
new Word { id =232 ,callNumber =0,numberOfLetters =10  ,word = "Вилохвостк",  description = ""},
new Word { id =233 ,callNumber =0,numberOfLetters =10  ,word = "Древесница",  description = ""},
new Word { id =234 ,callNumber =0,numberOfLetters =10  ,word = "Ленточница",  description = ""},
new Word { id =235 ,callNumber =0,numberOfLetters =10  ,word = "Нектарница",  description = ""},
new Word { id =236 ,callNumber =0,numberOfLetters =10  ,word = "Саламандра",  description = ""},
new Word { id =237 ,callNumber =0,numberOfLetters =10  ,word = "Тростнянка",  description = ""},
new Word { id =238 ,callNumber =0,numberOfLetters =10  ,word = "Трясогузка",  description = ""},
new Word { id =239 ,callNumber =0,numberOfLetters =11  ,word = "Желтоглазка",  description = ""},
new Word { id =240 ,callNumber =0,numberOfLetters =11  ,word = "Ложноглазка",  description = ""},
new Word { id =241 ,callNumber =0,numberOfLetters =11  ,word = "Медоуказчик",  description = ""},
new Word { id =242 ,callNumber =0,numberOfLetters =11  ,word = "Плоскохвост",  description = ""},
new Word { id =243 ,callNumber =0,numberOfLetters =11  ,word = "Сколопендра",  description = ""},
new Word { id =244 ,callNumber =0,numberOfLetters =11  ,word = "Трёхпёрстка",  description = ""},
new Word { id =245 ,callNumber =0,numberOfLetters =11  ,word = "Широколобка",  description = ""},
new Word { id =246 ,callNumber =0,numberOfLetters =11  ,word = "Щитомордник",  description = ""},
new Word { id =247 ,callNumber =0,numberOfLetters =11  ,word = "Буревестник",  description = ""},
new Word { id =248 ,callNumber =0,numberOfLetters =11  ,word = "Веерокрылка",  description = ""},
new Word { id =249 ,callNumber =0,numberOfLetters =11  ,word = "Вислокрылка",  description = ""},
new Word { id =250 ,callNumber =0,numberOfLetters =11  ,word = "Змееящерица",  description = ""},
new Word { id =251 ,callNumber =0,numberOfLetters =11  ,word = "Пересмешник",  description = ""},
    new Word { id =252 ,callNumber =0,numberOfLetters =11  ,word = "Скрытохвост",  description = ""},
    new Word { id =253 ,callNumber =0,numberOfLetters =11  ,word = "Широконоска",  description = ""},
    new Word { id =254 ,callNumber =0,numberOfLetters =12  ,word = "Перепелятник",  description = ""},
    new Word { id =255 ,callNumber =0,numberOfLetters =12  ,word = "Веерохвостка",  description = ""}

        };



    }




}