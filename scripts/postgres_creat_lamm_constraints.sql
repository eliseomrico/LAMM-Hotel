-----------------
-- CONSTRAINTS --
-----------------

-- CUSTOMER CONSTRAINTS 
ALTER TABLE CUSTOMER
ADD CONSTRAINT FK_CUSTOMER_CREDIT_CARD FOREIGN KEY (CUST_CREDIT_CARD_NO) -- CUSTOMER -> CREDIT CARD
	REFERENCES CREDIT_CARD (CREDIT_CARD_NO);

-- TRANSACTIONS CONSTRAINTS
ALTER TABLE TRANSACTIONS
ADD CONSTRAINT FK_TRANSACTIONS_RESERVATION FOREIGN KEY (TRANS_RES_ID) -- TRANSACTIONS -> RESERVATION
	REFERENCES RESERVATION (RES_NO),
ADD CONSTRAINT CHK_TRANS_LIMIT CHECK (TRANS_AMT < 1000000); -- BUSINESS CONSTRAINT

-- EMPLOYEE CONSTRAINTS 
ALTER TABLE EMPLOYEE
ADD CONSTRAINT FK_EMPLOYEE_LOCATION FOREIGN KEY (EMP_LOC_ID) -- EMPLOYEE -> LOCATION
	REFERENCES LOCATION (LOC_ID),
ADD CONSTRAINT FK_EMPLOYEE_EMPLOYEE FOREIGN KEY (SUPER_ID) -- EMPLOYEE -> EMPLOYEE
	REFERENCES EMPLOYEE (EMP_ID);

-- LOCATION CONSTRAINTS 
ALTER TABLE LOCATION
ADD CONSTRAINT FK_LOCATION_EMPLOYEE FOREIGN KEY (LOC_SUPER_ID) -- LOCATION -> EMPLOYEE
	REFERENCES EMPLOYEE (EMP_ID);

-- RESERVATION CONSTRAINTS 
ALTER TABLE RESERVATION
ADD CONSTRAINT FK_RESERVATION_EMPLOYEE FOREIGN KEY (RES_EMP_ID) -- RESERVATION -> EMPLOYEE
	REFERENCES EMPLOYEE (EMP_ID),
ADD CONSTRAINT FK_RESERVATION_CUSTOMER FOREIGN KEY (RES_CUST_ID) -- RESERVATION -> CUSTOMER
	REFERENCES CUSTOMER (CUST_ID),
ADD CONSTRAINT FK_RESERVATION_LOCATION FOREIGN KEY (RES_LOC_ID) -- RESERVATION -> LOCATION
	REFERENCES LOCATION (LOC_ID),
ADD CONSTRAINT FK_RESERVATION_ROOM FOREIGN KEY (RES_ROOM_NO) -- RESERVATION -> ROOM
	REFERENCES ROOM (ROOM_NO);


-- ROOM CONSTRAINTS
ALTER TABLE ROOM
ADD CONSTRAINT FK_ROOM_LOCATION FOREIGN KEY (ROOM_LOC) -- ROOM -> LOCATION
	REFERENCES LOCATION (LOC_ID),
ADD CONSTRAINT FK_ROOM_ROOM_TYPE FOREIGN KEY (ROOM_TYPE) -- ROOM -> ROOM TYPE
	REFERENCES ROOM_TYPE (TYPE_CODE);
