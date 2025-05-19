using System.Collections.Generic;

namespace Metiz_Technologies.Classes
{
    internal class GlobalTranslation
    {
        internal static string ProgramLanguage(string lang, string keyValue)
        {
            switch (lang)
            {
                case "us":
                    return English[keyValue];
                case "ru":
                    return Russian[keyValue];
                case "ua":
                    return Ukrainian[keyValue];

                default: 
                    return English[keyValue];
            }
        }

        internal static Dictionary<string, string> English = new Dictionary<string, string>
        {
            //login | signUp
            ["User Name"] = "User Name",
            ["Password"] = "Password",
            ["Email"] = "Email",
            ["Login"] = "Login",
            ["Register"] = "Register",
            ["Login Here"] = "Login Here",
            ["Create New Account"] = "Create New Account",
            ["Show Password"] = "Show Password",
            ["Forgot Password"] = "Forgot Password",
            ["Welcome Back"] = "Welcome Back",
            ["Get Started"] = "Get Started"
        };

        internal static Dictionary<string, string> Russian = new Dictionary<string, string>
        {
            //login | signUp
            ["User Name"] = "Имя пользователя",
            ["Password"] = "Пароль",
            ["Email"] = "Почта",
            ["Login"] = "Вход",
            ["Register"] = "Зарегистрироваться",
            ["Login Here"] = "Вход Тут",
            ["Create New Account"] = "Создать Новый Аккаунт",
            ["Show Password"] = "Показать Пароль",
            ["Forgot Password"] = "Забыли Пароль",
            ["Welcome Back"] = "С Возвращением",
            ["Get Started"] = "Начать"
        };

        internal static Dictionary<string, string> Ukrainian = new Dictionary<string, string>
        {
            //login | signUp
            ["User Name"] = "Ім'я користувача",
            ["Password"] = "Пароль",
            ["Email"] = "Пошта",
            ["Login"] = "Вхід",
            ["Register"] = "Реєстрація",
            ["Login Here"] = "Вхіт Тут",
            ["Create New Account"] = "Створити Новий Аккаунт",
            ["Show Password"] = "Показати Пароль",
            ["Forgot Password"] = "Забули Пароль",
            ["Welcome Back"] = "З Поверненням",
            ["Get Started"] = "Почати"
        };
    }
}
