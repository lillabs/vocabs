SET FOREIGN_KEY_CHECKS=0;

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

SET FOREIGN_KEY_CHECKS=1;

insert into e_languages (Value)
VALUES ('English'),
       ('German');

insert into folders (folder_id, parent_folder_id, name, description, created_at)
values (1, null, '1AHIT', null, '2019-12-02 19:58:18'),
       (2, null, '2AHIT', null, '2020-12-02 19:58:18'),
       (3, null, '3AHIT', null, '2021-12-02 19:58:18'),
       (4, null, '4AHIT', null, '2022-12-02 19:58:18'),
       (5, 1, 'Unit 1', null, '2019-09-02 19:58:18'),
       (6, 1, 'Unit 2', null, '2019-10-02 19:58:18'),
       (7, 1, 'Unit 3', null, '2019-11-02 19:58:18'),
       (8, 1, 'Unit 4', null, '2019-12-02 19:58:18'),
       (9, 1, 'Unit 5', null, '2020-01-02 19:58:18'),
       (10, 1, 'Unit 6', null, '2020-02-02 19:58:18'),
       (15, 2, 'Unit 1', null, '2020-09-02 19:58:18'),
       (16, 2, 'Unit 2', null, '2020-10-02 19:58:18'),
       (17, 2, 'Unit 3', null, '2020-11-02 19:58:18'),
       (18, 2, 'Unit 4', null, '2020-12-02 19:58:18'),
       (19, 2, 'Unit 5', null, '2021-01-02 19:58:18'),
       (20, 2, 'Unit 6', null, '2021-02-02 19:58:18'),
       (21, 2, 'Unit 7', null, '2021-03-02 19:58:18'),
       (22, 2, 'Unit 8', null, '2021-04-02 19:58:18'),
       (23, 2, 'Unit 9', null, '2021-05-02 19:58:18'),
       (25, 3, 'Unit 1', null, '2021-09-02 19:58:18'),
       (26, 3, 'Unit 2', null, '2021-10-02 19:58:18'),
       (27, 3, 'Unit 3', null, '2021-11-02 19:58:18'),
       (28, 3, 'Unit 4', null, '2021-12-02 19:58:18'),
       (29, 3, 'Unit 5', null, '2022-01-02 19:58:18'),
       (30, 3, 'Unit 6', null, '2022-02-02 19:58:18'),
       (31, 3, 'Unit 7', null, '2022-03-02 19:58:18'),
       (32, 3, 'Unit 8', null, '2022-04-02 19:58:18'),
       (33, 3, 'Unit 9', null, '2022-05-02 19:58:18'),
       (34, 3, 'Unit 10', null, '2022-06-02 19:58:18'),
       (35, 4, 'Unit 1', null, '2022-09-02 19:58:18'),
       (36, 4, 'Unit 2', null, '2022-10-02 19:58:18'),
       (37, 4, 'Unit 3', null, '2022-11-02 19:58:18');


insert into study_sets (study_set_id, folder_id, name, description, created_at)
values (1, 5, 'Unit 1.1', null, '2019-09-02 19:58:18'),
       (2, 5, 'Unit 1.2', null, '2019-09-10 19:58:18'),
       (3, 5, 'Unit 1.3', null, '2019-09-11 19:58:18'),
       (4, 5, 'Unit 1.4', null, '2019-09-14 19:58:18'),
       (5, 6, 'Unit 2.1', null, '2019-10-02 19:58:18'),
       (6, 7, 'Unit 3.1', null, '2019-11-02 19:58:18'),
       (7, 8, 'Unit 4.1', null, '2019-12-02 19:58:18'),
       (8, 8, 'Unit 4.2', null, '2020-12-15 19:58:18'),
       (9, 9, 'Unit 5.1', null, '2020-01-02 19:58:18'),
       (10, 10, 'Unit 6.1', null, '2020-02-02 19:58:18'),
       (11, 15, 'Unit 1.1', null, '2020-09-02 19:58:18'),
       (12, 15, 'Unit 1.2', null, '2020-09-10 19:58:18'),
       (13, 15, 'Unit 1.3', null, '2020-09-11 19:58:18'),
       (14, 15, 'Unit 1.4', null, '2020-09-14 19:58:18'),
       (15, 16, 'Unit 2.1', null, '2020-10-02 19:58:18'),
       (16, 16, 'Unit 2.2', null, '2020-10-03 19:58:18'),
       (17, 16, 'Unit 2.3', null, '2020-10-15 19:58:18'),
       (18, 17, 'Unit 3.1', null, '2020-11-03 19:58:18'),
       (19, 17, 'Unit 3.2', null, '2020-11-08 19:58:18'),
       (20, 18, 'Unit 4.1', null, '2020-12-02 19:58:18'),
       (21, 18, 'Unit 4.2', null, '2020-12-07 19:58:18'),
       (22, 19, 'Unit 5.1', null, '2021-01-03 19:58:18'),
       (23, 20, 'Unit 6.1', null, '2021-02-16 19:58:18'),
       (24, 21, 'Unit 7.1', null, '2021-03-14 19:58:18'),
       (25, 21, 'Unit 7.2', null, '2021-03-25 19:58:18'),
       (26, 22, 'Unit 8.1', null, '2021-04-02 19:58:18'),
       (27, 22, 'Unit 8.2', null, '2021-04-04 19:58:18'),
       (28, 23, 'Unit 9.1', null, '2021-05-15 19:58:18'),
       (29, 23, 'Unit 9.2', null, '2021-05-17 19:58:18'),
       (30, 23, 'Unit 9.3', null, '2021-05-29 19:58:18');
