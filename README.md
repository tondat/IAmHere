# IAmHere

This is a Xamarin.Forms sample app that lets people easily locate family and friends on a map.

Based on the concept of a family group we can create an account and we can register new users on the family group sharing a QR code.

Child accounts can be created without a login. This account won't be able to log out from the app, this should be done from an adult account.
Adult accounts requires a login to the app.

We have the following modes:

1. Panic button: a child account can send a notification to the parent and receive a reception which is shown on a map.

2. Pick up me: we can send a notification to another account to pick up us and wait for the notification seeing the progress on a map if we choose the live mode.

3. Where are you?: we send a notification to another account and wait for the response to see on a map where is located the other person.

The main goal is an experiment with Xamarin.Forms using visual studio Xamarin extension.

Tech proposal:
* QR generation/loading
* Azure
* MQTT
* Maps (google map, apple map)
  - https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/map
  - https://developer.xamarin.com/samples/xamarin-forms/CustomRenderers/Map/Pin/	
* Info bars
* Local storage
* P2P
* Social account login
  - https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/authentication/oauth


External Links:
* https://github.com/xamarin/Xamarin.Forms
* https://docs.microsoft.com/en-us/xamarin/xamarin-forms/
* https://developer.xamarin.com/samples/xamarin-forms/
