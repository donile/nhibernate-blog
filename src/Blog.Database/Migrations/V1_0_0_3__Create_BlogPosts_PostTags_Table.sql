CREATE TABLE BlogPosts_PostTags (
    BlogPostId INTEGER NOT NULL,
    PostTagId INTEGER NOT NULL,
    CONSTRAINT FK_BlogPosts_PostTags_BlogPosts FOREIGN KEY (BlogPostId)
        REFERENCES BlogPosts (Id),
    CONSTRAINT FK_BlogPosts_PostTags_PostTags FOREIGN KEY (PostTagId)
        REFERENCES PostTags (Id)
);

INSERT INTO BlogPosts_PostTags (BlogPostId, PostTagId)
    VALUES (
        1, 1
    );