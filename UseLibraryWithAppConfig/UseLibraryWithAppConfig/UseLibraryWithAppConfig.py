import clr
clr.AddReference("SomeLibrary")
from SomeLibrary import Helper
from system_configuration import ConfigurationProxy

# create configuration proxy/redirection to custom config    
proxy = ConfigurationProxy("my.config")
proxy.InjectToConfigurationManager()

# use .NET function which utilizes ConfigurationManager
someValue = Helper.GetSomeValueUsingConfig()
print someValue