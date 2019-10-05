# Shutdown Timer Classic
Shutdown Timer Classic or otherwise known as ShutdownTimerWin32 is a small little Windows application that allows you to set a timer which will shutdown, restart, hibernate, sleep or lock your PC.
<p align="center">
  <img alt="Screenshot of the main menu" src="Images/Menu.png">
</p>

I also have a UWP based version of this project which will be available on the Microsoft Store when it's ready but that will take some time. Once the project is ready I will update this document and my website.

# Usage
Shutdown Timer is a very simple application hence it is easy to use.
Just choose a power action (method) from the drop-down menu and then dial in the time span you want. If the counter reaches zero the chosen power action will be executed.

By default, the countdown window will be always on top of every other window so you don't forget that you have an active shutdown timer. The countdown can also be hidden by selecting the "Run in background" checkbox under the dropdown menu.
<p align="center">
  <img alt="Screenshot of the main menu with extended combobox" src="Images/Menu2.png">
</p>

# Colors
The countdown window has 4 different background colors to visualize the time left and one animation to draw your attention when the time is about to run out, in case you forget about the shutdown timer.
Here is a quick overview:

| Time left     | Color         | Animated  |
| ------------- | ------------- | --------- |
| > 30 min.     | Green         | No        |
| 30 - 10 min.  | Yellow        | No        |
| 10 - 1 min.   | Orange        | No        |
| < 1min.       | Red / Black   | Yes       |

<p align="center">
  <img alt="Screenshot of countdown window with green background" src="Images/CountdownGreen.png">
  <img alt="Screenshot of countdown window with yellow background" src="Images/CountdownYellow.png">
  <img alt="Screenshot of countdown window with orangebackground" src="Images/CountdownOrange.png">
  <img alt="Screenshot of countdown window with red background" src="Images/CountdownRed.png">
  <img alt="Screenshot of countdown window with black background" src="Images/CountdownBlack.png">
</p>

# Behavior
## Shutdown sequence
When a shutdown is executed all windows will be closed, regardless if they resist or not so any unsaved work will be gone. This is done so that you can be sure your PC actually shuts down and can not be stopped by some random application that waits for user input before closing or something. Please note that I am not liable for any data loss because you didn't save that extremely important document and now it's gone. That is your fault!

## Canceling the shutdown
As long as the timer has not reached zero, you can cancel the countdown at any time by simply pressing the close button (that big X in the top right corner). A dialog will then pop up asking you if you want to cancel. If you choose so, the countdown will be immediately canceled and another message will tell you that the countdown was successfully canceled and that the application will close after clicking OK. At this point, the countdown has already stopped and you have all the time you want before clicking ok, which results in the application closing itself.

## Logging and Privacy
The application is not connected to the internet and does not log any user data what so ever. The only things stored on your machine are the application itself and a small boolean, so the application knows if you have seen the license message or not (this is checked on every launch and in case you have not seen the message it will be shown before the main menu pops up).