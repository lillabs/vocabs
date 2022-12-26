delete
from e_languages
where true;

delete
from folders
where true;

delete
from study_sets
where true;

delete
from wordpairs
where true;

delete
from words_st
where true;

insert into e_languages (Value)
VALUES ('English'),
       ('German');

insert into folders (folder_id, parent_folder_id, name, description)
values (1, null, '3AHIT', null),
       (2, null, '2AHIT', null),
       (3, null, '1AHIT', null),
       (4, 1, 'Unit 4', null),
       (5, 1, 'Unit 3', null),
       (6, 1, 'Unit 2', null),
       (7, 1, 'Unit 1', null),
       (8, 2, 'Unit 1', null),;
