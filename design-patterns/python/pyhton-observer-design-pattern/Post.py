class Post:
    def __init__(self, publisher, content):
        self._publisher = publisher
        self._content = content

    @property
    def publisher(self):
        return self._publisher

    @publisher.setter
    def publisher(self, publisher):
        self._publisher = publisher

    @property
    def content(self):
        return self._content

    @content.setter
    def content(self, content):
        self._content = content

    def __str__(self):
        return self._publisher.name  # Burada get_content yerine content kullanabilirsiniz
