# hololensunity

This is the "backend" of the hololensunity project.

The plan is to have a webserver on azure where people can connect to and where devices can send their device information to the hololens.

On the web app side, people will simply browse to a url and input simple text strings. These strings will be serialized into json and sent to the unity app.

The unity side will take in json, make cubes representing the text string and have a ui element where the text will be displayed.

Potential features:

- music player
- device information with audience interaction
