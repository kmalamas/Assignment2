# Assignment2

Implementation of FullContact API interface to be used with console application. The user can input an email address to lookup a contact by email.

Solution Description
The solution consists of three projects, which will be described below:

FullContactClientCore project which is a .Net core class library and contains the model for the information retrieved from the API as well as the IFullContactApi interface.

FullContactClient project which is also a .Net core class library and contains the implementation of the interface. In order to map the json response to the model Newtosoft package is used. The request is made using the HttpClient.

ConsoleApp project which is a .Net core console application used as UI. Upon starting the application, it prompts the user to input an email address in order to fetch the following fields: likelihood, contact info and social profiles. Nito.AsyncEx.Context is used to enable an async/await-compatible SynchronizationContext.

TODO
Although this is a working solution there are still a few things to be done.

1)Remove hardcoded api key and move it to config file.

2)Check for error handling.

3)create tests. Although Newtonsoft handles JSON parsing the mapping to objects can be tested. Also input validation can be tested.





  <ItemGroup>
    <EmbeddedResource Include="Recources\*.png" />
  </ItemGroup>
  
  
  
var label = "Resources/label_g.png";
            //var assembly = typeof(FullContactClient.FullContactAPI).GetTypeInfo().Assembly;
            //Stream resource = assembly.GetManifestResourceStream($"FullContactClient.Resources.{label}");
            using (var image = new MagickImage(label))
            {
                image.Write("arrow.png");
            }

