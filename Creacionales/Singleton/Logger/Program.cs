using Logger;

var logger = LoggerSingleton.GetInstancia();
logger.Log("Este es un mensaje de log.");

var logger2 = LoggerSingleton.GetInstancia();
logger2.Log("Este es un mensaje de log.");

var logger3 = LoggerSingleton.GetInstancia();
logger3.Log("Este es un mensaje de log.");