CREATE TABLE BlogPosts (
    Id INTEGER,
    Title VARCHAR(256) NOT NULL,
    CONSTRAINT PK_BlogPostsId PRIMARY KEY (Id)
);

insert into BlogPosts ( Id, Title )
    VALUES (
        1, 'Initial Blog Post'
    );