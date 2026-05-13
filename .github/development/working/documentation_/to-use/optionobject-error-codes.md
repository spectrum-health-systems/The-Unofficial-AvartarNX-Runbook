#  OptionObject Error Codes

When an OptionObject is returned to Avatar, it requires one of the following single-digit integer Error Codes:

0 - No action taken
1 - Returns an Error Message with an "Ok" button, and stops further processing of scripts
2 - Returns an Error Message with "OK" and "Cancel" buttons, and stops further scripts the user clicks "Cancel"
3 - Returns an Error Message with "Ok" button
4 - Returns an Error Message with "Yes" and "No" buttons and stops further scripts the user clicks "No"
5 - Returns a URL to be opened in a new browser
6 - Returns a form to be opened in Avatar
Common Error Codes
The most common error codes are:

1 - Used when you don't want the user to take an action, such as submitting a form
3 - Used when you would like to notify the user of something
4 - Used when you want warn the user they may want to make changes, and give them the option to stop further
processing,or continuing