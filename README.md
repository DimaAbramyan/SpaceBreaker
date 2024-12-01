# SpaceBreaker
SpaceBreaker - 2D игра в жанре shoot ‘em up          в космическом сеттинге
## Описание идеи
Игра разбита на уровни. На каждом уровне игроку требуется уничтожить всех противников, а так же победить босса (при наличии). 
## Фишка
Особенностью игры является возможность кастомизации корпуса различным орудием.

## Цель проекта 
Целью проекта является создание игры с вышеперечисленными особенностями, а также получить опыт в разработке и научиться работать в команде. Для этого необходимо выполнить следующие задачи:
- Распределить роли в команде 
- Разработать основные игровые механики
- Нарисовать спрайты
- Построить уровни
- Написать саундтрек
- Провести тестирование игры
## Описание игрового процесса
### Интерфейс
Игроку предлагается на выбор 3 корабля(тяжёлый, средний и лёгкий). В зависимости от корабля меняется его манёвренность, здоровье и экипированное вооружение. У каждого корабля своё здоровье. Выбор между тяжёлым, средним и лёгким кораблём осуществляется снизу специальными кнопками. Сверху показано здоровье текущего корабля, и при гибели одного из кораблей игра начинается заново.
### Враги
На данной версии существует 3 врага: обычный, щитоносец и крейсер. 

Обычный стреляет перед собой раз в 2-4 секунды.

Щитоносец экипирован щитом(логично), имеет увеличенное здоровье, однако не имеет при себе вооружения.

Крейсер отличается увеличенным здоровьем, вооружён 4 турелями, которые могут быть уничтожены отдельно. Турели стреляют в игрока, так что придётся уворачиваться (на тяжёлом корабле это невозможно).
### Улучшение
С врагов с вероятностью 12.5% при смерти выпадает улучшение, которое увеличивает уровень вооружения(увеливает кол-во пушек, дальность атаки и т.д.), максимальный уровень - 5. Улучшение работает только на 1 корпусе.
### Вооружене
На данном этапе игрок обладает 3 видами вооружения:
- Пулемёт (Каждые 100 выстрелов выпускает 100 дробинок, наносящие незначительный урон).
- Огнемёт (Малая дистанция поражения, но большой урон и способность пробивать насквозь противников).
- Лазерная установка (Дистанция поражения не ограничена, но ценой небольшого урона. Пробивает насквозь противников).
