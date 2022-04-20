FileLogger fileLogger = new FileLogger();
fileLogger.writeLog();

DatabaseLogger databaseLogger = new DatabaseLogger();
databaseLogger.writeLog();

SmsLogger smsLogger = new();
smsLogger.writeLog();


LogManager logManager = new LogManager(new DatabaseLogger());
logManager.writeLog();