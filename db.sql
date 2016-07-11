CREATE database restaurantPOS;
GO
use restaurantPOS;
GO
CREATE table auth (
	auth_id int primary key identity(1,1),
	auth_name_en nvarchar(255),
	auth_name_ar nvarchar(255),
);

CREATE table users_role (
	role_id int primary key identity(1,1),
	role_name_en nvarchar(255),
	role_name_ar nvarchar(255),
);

CREATE table role_auth (
	role_auth_id int primary key identity(1,1),
	role_id int,
	auth_id int,
	CONSTRAINT fk_role_auth_role_id FOREIGN KEY (role_id) REFERENCES users_role(role_id),
	CONSTRAINT fk_role_auth_auth_id FOREIGN KEY (auth_id) REFERENCES auth(auth_id)
);

CREATE table users (
	users_id int primary key identity(1,1),
	users_name nvarchar(255),
	users_pass nvarchar(50),
	is_active bit,
	role_id int,
	CONSTRAINT fk_users_role_id FOREIGN KEY (role_id) REFERENCES users_role(role_id)
);

CREATE table prog_setting(
	id int primary key identity(1,1),
	name_en nvarchar(255),
	name_ar nvarchar(255),
	address_en nvarchar(255),
	address_ar nvarchar(255),
	telephone_no nvarchar(20),
	mobile_no nvarchar(20),
	website nvarchar(255),
	reset_footer ntext
);

CREATE table clients(
	client_id int primary key identity(1,1),
	client_name_en nvarchar(255),
	client_name_ar nvarchar(255),
	client_address_ar nvarchar(255),
	client_address_en nvarchar(255),
	client_telephone_no nvarchar(20),
	client_mobile_no nvarchar(20)
);

CREATE table suppliers(
	supplier_id int primary key identity(1,1),
	supplier_name_en nvarchar(255),
	supplier_name_ar nvarchar(255),
	supplier_address_en nvarchar(255),
	supplier_address_ar nvarchar(255),
	supplier_telephone_no nvarchar(20),
	supplier_mobile_no nvarchar(20)
);

CREATE table units(
	unit_id int primary key identity(1,1),
	unit_name_en nvarchar(255),
	unit_name_ar nvarchar(255)
);

CREATE table goods(
	goods_id int primary key identity(1,1),
	goods_name_en nvarchar(255),
	goods_name_ar nvarchar(255),
	unit_id int,
	CONSTRAINT fk_goods_unit_id FOREIGN KEY (unit_id) REFERENCES units(unit_id)
);

CREATE table category(
	category_id int primary key identity(1,1),
	category_name_en nvarchar(255),
	category_name_ar nvarchar(255),
);

CREATE table items(
	item_id int primary key identity(1,1),
	item_name_en nvarchar(255),
	item_name_ar nvarchar(255),
	item_price decimal(10,3)
);

CREATE table items_goods(
	item_id int,
	goods_id int,
	CONSTRAINT fk_items_goods_item_id FOREIGN KEY (item_id) REFERENCES items(item_id),
	CONSTRAINT fk_items_goods_goods_id FOREIGN KEY (goods_id) REFERENCES goods(goods_id),
	PRIMARY KEY (item_id, goods_id)
);

CREATE table store_actions(
	store_actions_id int primary key identity(1,1),
	goods_id int,
	quantity decimal(10,3),
	action_date dateTime,
	users_id int,
	supplier_id int,
	reason nvarchar(255)
);
GO
ALTER table clients add client_special_item int ;

ALTER table clients add constraint fk_clients_client_special_item FOREIGN KEY (client_special_item) REFERENCES items(item_id);

-----------
GO
insert into users_role values ('admin', N'الأدمن');

insert into users_role values ('cashier', N'كاشير');

insert into users values ('admin', 'admin123', 1, 1);

insert into users values ('heba', 'heba123', 1, 2);


insert into auth values ('pos', N'الطلبات');
insert into auth values ('tickets', N'التذاكر');
insert into auth values ('workPeriods', N'فترات العمل');
insert into auth values ('Menu', N'القائمة');
insert into auth values ('warhouses', N'المخازن');
insert into auth values ('accounts', N'الحسابات');
insert into auth values ('reports', N'التقارير');
insert into auth values ('manage', N'الاعدادات');

insert into role_auth VALUES (1, 1);
insert into role_auth VALUES (1, 8);

insert into role_auth VALUES (1, 1);
insert into role_auth VALUES (1, 2);

--------------27-06-2016---heba-----
GO
ALTER table users add user_name_ar nvarchar(255);
------------- 28-06-216-----heba--------
alter table items add category_id int;

ALTER table items add constraint fk_items_category_id FOREIGN KEY (category_id) REFERENCES category(category_id);

------------02-07-2016----heba----------
--ALTER TABLE items ADD 
------------03-07-2016----kajoo----------
ALTER Table clients Add	Is_VIP bit
ALTER table clients add client_email nvarchar(255)
------------11-07-2016----kajoo----------
CREATE table dineIn_tables
(
dineIn_table_id int primary key identity(1,1),
dineIn_table_name nvarchar(255),
dineIn_table_isVip bit,
dineIn_table_chair_number int
);
CREATE table dineIn_tables_status(
table_status_id int primary key identity(1,1),
table_status nvarchar(255),
table_color nvarchar(255),
dineIn_table_id int,
constraint fk_dineIn_tables_status_dineIn_table_id Foreign key (dineIn_table_id) references dineIn_tables(dineIn_table_id)
);