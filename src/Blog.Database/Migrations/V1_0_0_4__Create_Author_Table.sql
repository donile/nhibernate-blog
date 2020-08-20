CREATE TABLE Authors (
    Id INTEGER,
    FirstName VARCHAR(256),
    BlogPostId INTEGER NOT NULL,
    CONSTRAINT PK_AuthorsId PRIMARY KEY (Id),
    CONSTRAINT FK_Authors_BlogPosts FOREIGN KEY (BlogPostId)
        REFERENCES BlogPosts (Id)
);

INSERT INTO Authors (Id, FirstName, BlogPostId)
    VALUES (1, 'Mark', 1);