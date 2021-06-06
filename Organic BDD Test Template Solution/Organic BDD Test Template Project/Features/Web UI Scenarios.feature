Feature: Web UI Scenarios
	Simple demonstration of spinning up a web driver.


Scenario: Go to URL: Firefox
	Given a "firefox" web driver is constructed
	When the web driver navigates to "https://everynband.com"
	Then the web page title is "Welcome to our website | everyn-music-collective.github.io"

Scenario: Go to URL: Chrome
	Given a "chrome" web driver is constructed
	When the web driver navigates to "https://everynband.com"
	Then the web page title is "Welcome to our website | everyn-music-collective.github.io"


