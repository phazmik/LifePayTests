﻿# language: ru

Функция: Набор проверок для страницы авторизации

@greeting_time
Сценарий: Корректное отображения приветствия в соответствии со временем суток
	Допустим системное время равно <Время> часам
	Когда Открыта страница авторизации LifePay
	Тогда отображается '<Приветствие>'

@id_gr_morning
Примеры:
| Время     | Приветствие  |
| 6:45:0 AM | Доброе утро! | 

@id_gr_afternoon
Примеры:
| Время      | Приветствие  |
| 12:15:0 PM | Добрый день! |

@id_gr_evening
Примеры:
| Время     | Приветствие   |
| 6:20:5 PM | Добрый вечер! |

@id_gr_evening
Примеры:
| Время      | Приветствие  |
| 01:00:7 AM | Доброй ночи! |

@successful_auth_field_fillment
Сценарий: Успешное заполнение полей ввода при авторизации
	Допустим Открыта страница авторизации LifePay
	И данные авторизации известны
	Когда поле ввода Номер телефона заполнено
	И поле ввода Пароль заполнено
	Тогда поля ввода принимают соответствующие значения

@link_test
Сценарий: Переход по ссылкам экрана Авторизации
	Допустим Открыта страница авторизации LifePay
	Когда происходит нажатие на ссылку '<Текст ссылки>'
	Тогда происходит переход по ссылке '<Ссылка>'

@id_reset_pass
Примеры:
| Текст ссылки        | Ссылка                               |
| Восстановить пароль | https://my.life-pos.ru/auth/recovery | 

@id_sign_up
Примеры:
| Текст ссылки     | Ссылка                              |
| Заведите аккаунт | https://my.life-pos.ru/auth/sign-up |

@num_doesnot_reg
Сценарий: При введении не зарегистрированного номера телефона выводится соответствующее сообщение
	Допустим Открыта страница авторизации LifePay 
	И незарегистрированный номер известен
	Когда поле ввода Номер телефона заполнено
	Тогда отображается сообщение Номер не зарегистрирован

@incorrect_num
Сценарий: При введении некорретного номера телефона выводится соответствующее сообщение
	Допустим Открыта страница авторизации LifePay
	И некорректный номер известен
	Когда поле ввода Номер телефона заполнено
	Тогда отображается сообщение Введите номер в формате '+7(911)111-11-11'

@incorrect_length_pas
Сценарий: При введении пароля длиной менее 6 знаков выводится соответствующее сообщение
	Допустим Открыта страница авторизации LifePay
	И некорректный пароль известен
	Когда поле ввода Пароль заполнено
	Тогда отображается сообщение Значение должно быть не менее 6 знаков
	
@successful_auth_no_inplimentation
Сценарий: Успешная авторизация
	Допустим Открыта страница авторизации LifePay
	И данные авторизации известны 
	Когда поле ввода Номер телефона заполнено
	И поле ввода Пароль заполнено
	И нажата кнопка Войти в личный кабинет
	Тогда происходит редирект в личный кабинет	

@successful_reg_no_inplimentation
Сценарий: Успешная регистрация
	Допустим Открыта страница авторизации LifePay
	И данные регистрации известны 
	Когда поле ввода Номер телефона заполнено
	И поле ввода Код из SMS заполнено
	И поле ввода Ваше имя и фамилия заполнено
	И поле ввода Пароль заполнено
	И нажата кнопка Создать личный кабинет
	Тогда происходит редирект в личный кабинет

