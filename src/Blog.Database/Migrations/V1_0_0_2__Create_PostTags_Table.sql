CREATE TABLE PostTags (
    Id INTEGER,
    TagValue VARCHAR(256) NOT NULL,
    CONSTRAINT PK_PostTagsId PRIMARY KEY (Id)
);

INSERT INTO PostTags (Id, TagValue)
    VALUES (
        1, 'Awesome'
    );