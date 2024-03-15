﻿# language: ru

Функция: Набор проверок для страницы авторизации

@greeting_time
Сценарий: Корректное отображения приветствия в соответствии со временем суток
	Допустим системное время равно <Время> часам
	Когда Открыта страница авторизации LifePay
	Тогда отображается '<Приветствие>'

@morning @id_gr001
Примеры:
| Время     | Приветствие  |
| 6:45:0 AM | Доброе утро! | 

@afternoon @id_gr002
Примеры:
| Время      | Приветствие  |
| 12:15:0 PM | Добрый день! |

@evening @id_gr003
Примеры:
| Время     | Приветствие   |
| 6:20:5 PM | Добрый вечер! |

@night @id_gr004
Примеры:
| Время      | Приветствие  |
| 01:00:7 AM | Доброй ночи! |

@field_fill @id_fi001
Сценарий: Успешное заполнение полей ввода при авторизации
	Допустим Открыта страница авторизации LifePay
	Когда поле ввода '<Имя поля>' заполнено значением '<Значение>'
	Тогда отображается значение '<Значение>' в поле ввода '<Имя поля>'

Примеры:
| Имя поля       | Значение         |
| Номер телефона | +7(911)111-11-11 |
| Пароль         | @12345#6789!     |

@link_click
Сценарий: Переход по ссылкам экрана Авторизации
	Допустим Открыта страница авторизации LifePay
	Когда происходит нажатие на ссылку '<Текст ссылки>'
	Тогда происходит переход по ссылке '<Ссылка>'

@recovery @id_cl001
Примеры:
| Текст ссылки        | Ссылка                               |
| Восстановить пароль | https://my.life-pos.ru/auth/recovery | 

@sign_up @id_cl002
Примеры:
| Текст ссылки     | Ссылка                              |
| Заведите аккаунт | https://my.life-pos.ru/auth/sign-up |

@warning_displayed
Сценарий: Отображение предупреждения полей ввода при введении триггерных значений
	Допустим Открыта страница авторизации LifePay 
	Когда поле ввода '<имя Поля>' заполнено значением '<Значение>'
	Тогда отображается предупреждение '<Предупреждение>' в поле '<имя Поля>' 

@unreg_phone @id_di001
Примеры:
| Имя поля       | Значение         | Предупреждение           |
| Номер телефона | +7(911)111-11-12 | Номер не зарегистрирован |

@incor_phone @id_di002
Примеры:
| Имя поля       | Значение        | Предупреждение                             |
| Номер телефона | +7(911)111-11-1 | Введите телефон в формате +7(911)111-11-11 |

@incor_length_pass @id_di003
Примеры:
| Имя поля | Значение | Предупреждение                         |
| Пароль   | @1234    | Значение должно быть не менее 6 знаков |

@auth_no_inplim @id_au001
Сценарий: Успешная авторизация
	Допустим Открыта страница авторизации LifePay
	Когда поле ввода Номер телефона заполнено значением 
	И поле ввода Пароль заполнено значением
	И нажата кнопка Войти в личный кабинет
	Тогда происходит редирект в личный кабинет	

@reg_no_inplim @id_re001
Сценарий: Успешная регистрация
	Допустим Открыта страница авторизации LifePay
	Когда поле ввода Номер телефона заполнено значением
	И поле ввода Код из SMS заполнено
	И поле ввода Ваше имя и фамилия заполнено
	И поле ввода Пароль заполнено значением
	И нажата кнопка Создать личный кабинет
	Тогда происходит редирект в личный кабинет

